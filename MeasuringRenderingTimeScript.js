// ==UserScript==
// @name         Responsetimes measurements
// @namespace    http://tampermonkey.net/
// @version      2025-02-24
// @description  Script to measure rendering times. Used for my thesis project.
// @author       You
// @match        https://localhost:7053/
// @match        https://localhost:7290
// ==/UserScript==

(function () {
    'use strict';

    let nrOfMeasurements = 50;
    function measureResponseTimes() {
        let prevTime = localStorage.getItem("prevTime");
        let cnt;

        const observer = new MutationObserver((mutations, obs) => {
            const element = document.querySelector("td.mud-table-cell");
            if (element) {
                if (parseInt(prevTime) > 0)/*if not first measurement*/ {
                    let newTime = performance.timeOrigin + performance.now()
                    let responseTime = newTime - prevTime;
                    let row = localStorage.getItem("measurements") || "data:text/csv;charset=utf-8,";
                    cnt = parseInt(localStorage.getItem("counter")) || 0;
                    cnt++;
                    row += cnt + "," + prevTime + "," + newTime + "," + responseTime + "\n";
                    localStorage.setItem("counter", cnt);
                    localStorage.setItem("measurements", row);
                    localStorage.removeItem("prevTime");

                } else/*if firts measurement set headertitles*/ {
                    let row = "data:text/csv;charset=utf-8,";
                    row += "count,startTime,endTime,reponsTime\n";
                    localStorage.setItem("measurements", row);
                }
                if (cnt >= nrOfMeasurements)/*if this was the last measurement*/ {
                    alert("This was the last measurment, you will now download " + cnt + " measurements.");
                    localStorage.setItem("counter", 0);
                    downloadData();
                    obs.disconnect();
                    return;
                } else {
                    let startTime = performance.timeOrigin + performance.now()
                    localStorage.setItem("prevTime", startTime);
                    location.reload();
                }
            }
        });
        observer.observe(document.body, { childList: true, subtree: true });
    }


    function downloadData() {
        let data = localStorage.getItem("measurements");
        if (data) {
            let link = document.createElement("a");
            link.setAttribute("href", encodeURI(data));
            link.setAttribute("download", "timing_data.csv");
            document.body.appendChild(link);
            link.click();
            localStorage.setItem("measurements", "");
        }
    }

    measureResponseTimes();
})();