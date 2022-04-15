// ==UserScript==
// @name         Episode names
// @namespace    http://tampermonkey.net/
// @version      1.0
// @description  try to take over the world!
// @author       You
// @match        https://www.imdb.com/title/*/episodes?*
// @icon         https://www.google.com/s2/favicons?sz=64&domain=imdb.com
// @grant        none
// ==/UserScript==

(function() {
    'use strict';


    const outputNames = () => {

        const title = document.querySelector('.aux-content-widget-2.links.subnav a').textContent;

        const $episodes = document.querySelectorAll('.list.detail.eplist>div>div>strong>a');

        const $main = document.querySelector('.subpage_title_block');
        const $Temp = document.createElement('ul')
        $Temp.classList.add('EpisodeList')


         Array.prototype.forEach.call($episodes, (episodeName, key) => {
             const $listItem = document.createElement('li');
             $listItem.textContent = ((`${title} - S01E${(key+1) >= 10 ? (key+1) : '0'+(key+1)} - ${episodeName.textContent}`).replace(/\/$/, "").replace(':', '').replace('.', '').replace('"', '').replace("'", ''));
             $Temp.appendChild($listItem)
            });

        $main.appendChild($Temp)

    };


    //IMBD Removes the element when a new season gets loaded in so we have to reassign the eventlistener every time
    const assignEventListener = () => {
     document.querySelector('#bySeason').addEventListener('change', () => {
         setTimeout(() => {
             document.querySelector('.EpisodeList').remove();
             outputNames();
             assignEventListener();
         },
         1500)
     });
    }

    assignEventListener();
    outputNames();

})();
