import * as t0 from "./tool0";
import * as t1 from "./tool1";
import * as t2 from "./tool2";

const tools = {
  t0,
  t1,
  t2
};

const TOTAL_TOOLS = 3
var current_tool = 0;
const app_div = document.getElementById('app');
var div_arr = [];

const createToolDivs = () => {
  for(let i=0; i<TOTAL_TOOLS; i++){
    let new_div = document.createElement('div');
    new_div.id = `tool${i}`;
    new_div.classList.add('tool');
    app_div.appendChild(new_div);
    div_arr.push(new_div);
    tools['t'+i].setup(new_div);
  }
}

const hideAllTools = () => {
  div_arr.forEach(div => {
    div.style.display = 'none';
  });
};

const showTool = tool_num => {
  hideAllTools();
  div_arr[tool_num].style.display = 'block';
};

const handleClick = evt => {
  current_tool = Number(evt.target.id.substr(-1));
  showTool(current_tool);
};

const buildMenu = () => {
  let nav = document.createElement('nav');
  app_div.appendChild(nav);
  for(let i=0; i<TOTAL_TOOLS; i++){
    let new_btn_div = document.createElement('div');
    new_btn_div.id = `btn${i}`;
    new_btn_div.classList.add('menu_btn');
    new_btn_div.innerHTML = `Tool ${i}`;
    nav.appendChild(new_btn_div);
    new_btn_div.addEventListener('click', handleClick);
  }
};

const setup = () => {
  buildMenu();
  createToolDivs();
  showTool(current_tool);
};

const loop = () => {
  if(current_tool == 1) {
    tools.t1.update();
  }

  if(current_tool == 2) {
    tools.t2.update();
  }
};

setup();
setInterval(loop, 10);