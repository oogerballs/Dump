const contents = `
<h1>Tool 1</h1>
<div id='countHolder'>0</div>
<div id='start' class='btn'>Start</div>
<div id='stop' class='btn'>Stop</div>
<div id='reset' class='btn'>Reset</div>
`;

var count = 0;
var count_add = 0;

export const handleClick = evt => {
    switch(evt.target.id) {
        case 'start':
            count_add = 1;
            break;
        case 'stop':
            count_add = 0;
            break;

        case 'reset':
            count = 0;
            break;
    }
};


export const setup = div_container => {
    div_container.innerHTML = contents;
    document.getElementById('start').addEventListener('click', handleClick);
    document.getElementById('stop').addEventListener('click', handleClick);
    document.getElementById('reset').addEventListener('click', handleClick);
};


export const update = () => {
    count += count_add;
    document.getElementById('countHolder').innerHTML = `<h2>${count/100}</h2>`;
}