using SFML;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using SFML.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

RenderWindow window = new RenderWindow(new VideoMode(200,200), "test");
CircleShape cs = new CircleShape(100.0f);
cs.FillColor = Color.Green;
window.SetActive();
while (true)
{
    window.Clear();
    window.DispatchEvents();
    window.Draw(cs);
    window.Display();
}