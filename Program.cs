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

RenderWindow window = new RenderWindow(new VideoMode(x, y), "test", Styles.Fullscreen);
window.SetActive();
while (true)
{
    window.Clear();
    window.Display();
}