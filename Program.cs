using SFML;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using SFML.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

var t = VideoMode.DesktopMode;

uint x = t.Width;
uint y = t.Height;

RenderWindow window = new RenderWindow(new VideoMode(x, y), "DarkHouse", Styles.Fullscreen);
window.SetActive();

Music loading_mus = new Music("res/start/music/autors.mp3");
loading_mus.Play();

///Video render
Sprite loading = new Sprite (new Texture("res/start/autors.png"));
var x_load = (x / 2) - 300;
var y_load = (y / 2) - 90;
Vector2f loading1 = new Vector2f(x_load, y_load);
loading.Position = loading1;
///


window.SetFramerateLimit(120);


while (window.HasFocus())
{
    window.Clear();
    window.Draw(loading);
    window.Display();
}