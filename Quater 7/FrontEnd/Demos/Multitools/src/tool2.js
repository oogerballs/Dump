const contents = `
<h1>Tool 2</h1>
<canvas id='canvas' width='200' height='200'>
</canvas>
`;

var canvas;
var ctx;

export const setup = div_container => {
    div_container.innerHTML = contents;
    canvas = document.getElementById('canvas');
    ctx = canvas.getContext('2d');
};

export const drawSquare = (x, y) => {
    ctx.fillStyle = '#ff0';
    ctx.fillRect(x, y, 20, 20);
}

var px = 0;
export const update = () => {
    ctx.clearRect(0, 0 , 200, 200);
    px += 1;
    if(px > 200){
        px = -20;
    }
    drawSquare(px, 90);
};