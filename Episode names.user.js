// ==UserScript==
// @name         Episode names
// @namespace    http://tampermonkey.net/
// @version      2.0
// @description  try to take over the world!
// @author       You
// @match        https://www.imdb.com/title/*/episodes?*
// @icon         https://www.google.com/s2/favicons?sz=64&domain=imdb.com
// @grant        none
// ==/UserScript==

(function() {
    'use strict';
    let season = '01';

    const outputNames = () => {
        console.log('test')

        const title = document.querySelector('h2[data-testid="subtitle"]').textContent;

        const $episodes = document.querySelectorAll('h4>a');

        const $main = document.querySelector('.ipc-page-section');
        const $Temp = document.createElement('ul')
        $Temp.classList.add('EpisodeList')


         Array.prototype.forEach.call($episodes, (episodeName, key) => {
             const $listItem = document.createElement('li');
             $listItem.textContent = ((`${title} - S${season}E${(key+1) >= 10 ? (key+1) : '0'+(key+1)} - ${episodeName.textContent.split(' ∙ ')[1]}`).replace(/\/$/, "").replace(':', '').replace('.', '').replace('"', '').replace("'", ''));
             $Temp.appendChild($listItem)
            });

        $main.appendChild($Temp)

    };


    //IMBD Removes the element when a new season gets loaded in so we have to reassign the eventlistener every time
    const assignEventListener = () => {
     document.querySelector('.ipc-tabs').addEventListener('change', () => {
         setTimeout(() => {
             let seasonNumber = parseInt(document.querySelector('#episode_top').textContent.replace(/\D/g,''));
             if(seasonNumber >= 10) season = seasonNumber;
             else season = `0${seasonNumber}`;
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
