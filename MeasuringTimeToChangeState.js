// ==UserScript==
// @name         Time to change state
// @namespace    http://tampermonkey.net/
// @version      2025-02-24
// @description  Script to measure the time it takes to change the state of the application. Used for my thesis project.
// @author       You
// @match        https://localhost:7053
// @match        https://localhost:7290
// ==/UserScript==

(function () {
    'use strict';
    setTimeout(() => {
        let nrOfMeasurements = 100;

        function measureResponseTimes() {
            let cnt = parseInt(localStorage.getItem("counter")) || 0;
            let boxNrToSelect;
            let experimentStarted = false
            let waitingForReload = false;
            let nrOfSelections;
            let listOfAllSelectBoxes;
            let dataHasRendered = document.querySelector("td.mud-table-cell");
            let isNotFirstMeasurement = localStorage.getItem("measurements");
            let removeSelectedItemsButton = document.querySelector(".remove-item-btn");

            if (dataHasRendered) {
                console.log("1. Data has rendered")
                if (!experimentStarted) {
                    experimentStarted = true
                    listOfAllSelectBoxes = document.querySelectorAll('td[data-label="Select"] .mud-checkbox-input');
                    nrOfSelections = getRandomIntBetween(1, listOfAllSelectBoxes.length);
                    if (!isNotFirstMeasurement) {
                        let row = "data:text/csv;charset=utf-8,";
                        console.log("2. Write table headers")
                        row += "count,startTime,endTime,timeToChangeState,removedLines\n";
                        localStorage.setItem("measurements", row);
                    }
                    for (let i = 0; i < nrOfSelections; i++) {
                        boxNrToSelect = getRandomIntBetween(0, listOfAllSelectBoxes.length - 1);
                        if (listOfAllSelectBoxes[boxNrToSelect].checked == false) {
                            checkTheBox(listOfAllSelectBoxes[boxNrToSelect])
                        } else {
                            i--
                        }
                        console.log("3. Check boxes are checked " + boxNrToSelect)
                    }

                    startTimer();
                    console.log("4. Timer has started")
                    removeSelectedItemsButton.click()
                    console.log("5. Remove button is clicked")
                }


                let remainingBoxes = document.querySelectorAll('td[data-label="Select"] .mud-checkbox-input');
                console.log("6. Observe if checkbox is left or removed." + remainingBoxes.length, listOfAllSelectBoxes.length - nrOfSelections)
                console.log("time: " + performance.now())
                if (remainingBoxes.length < listOfAllSelectBoxes.length && waitingForReload == false) {
                    console.log("7. Checkbox is removed")
                    waitingForReload = true
                    if (cnt >= nrOfMeasurements)/*if this was the last measurement*/ {
                        console.log("9. All meaasurements are done, time to download the file")
                        console.log("time: " + (performance.timeOrigin + performance.now()))
                        alert("This was the last measurment, you will now download " + cnt + " measurements.");
                        localStorage.setItem("counter", 0);
                        downloadData();
                        return
                    }
                    let endTime = performance.timeOrigin + performance.now()
                    console.log("8. Timer has been stoped")
                    console.log("time: " + performance.now())
                    let responseTime = endTime - parseInt(localStorage.getItem("startTime"));
                    let row = localStorage.getItem("measurements") || "data:text/csv;charset=utf-8,";
                    cnt++;
                    row += cnt + "," + localStorage.getItem("startTime") + "," + endTime + "," + responseTime + "," + nrOfSelections + "\n";
                    localStorage.setItem("counter", cnt);
                    localStorage.setItem("measurements", row);
                    console.log("9. time: " + responseTime)
                    location.reload();
                }
            }
        }

        function startTimer() {
            let startTime = performance.timeOrigin + performance.now();
            localStorage.setItem("startTime", startTime);
        }

        function checkTheBox(checkbox) {
            checkbox.checked = true;
            checkbox.dispatchEvent(new Event("change", { bubbles: true }));
        }

        function getRandomIntBetween(min, max) {
            return Math.floor(Math.random() * (max - min + 1)) + min;
        }

        function downloadData() {
            let data = localStorage.getItem("measurements");
            if (data) {
                let link = document.createElement("a");
                link.setAttribute("href", encodeURI(data));
                link.setAttribute("download", "timing_data.csv");
                document.body.appendChild(link);
                link.click();
                localStorage.removeItem("startTime");
                localStorage.removeItem("counter");
                localStorage.setItem("measurements", "");
            }
        }

        measureResponseTimes();
    }, 2500)
})();