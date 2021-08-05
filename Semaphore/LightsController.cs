using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Semaphore
{
    
    static class LightsController
    {
        static LightsForm form;

        const double LightDuration = 1;
        const double BlinkDuration = 0.25;
        const int BlinkCount = 5;

        static void Wait(double timeInSeconds)
        {
            Thread.Sleep((int)(timeInSeconds * 1000));
        }
        static void LightOn(Lights color)
        {
            form.LightOn((int)color);
        }
        static void LightOff(Lights color)
        {
            form.LightOff((int)color);
        }
        static void Blink()
        {
            for (int i = 0; i <= BlinkCount; i++)
            {
                LightOn(Lights.Green);
                Wait(BlinkDuration);
                LightOff(Lights.Green);
                Wait(BlinkDuration);
            }
        }
        static void SwitchTo(Lights color)
        {
            LightOff(Lights.Red);
            LightOff(Lights.Yellow);
            LightOff(Lights.Green);
            LightOn(color);
        }
        static void Control()
        {
            Wait(LightDuration);
            while (true)
            {
                SwitchTo(Lights.Red);
                Wait(LightDuration);
                LightOn(Lights.Yellow);
                Wait(LightDuration);
                SwitchTo(Lights.Green);
                Wait(LightDuration);
                Blink();
                SwitchTo(Lights.Yellow);
                Wait(LightDuration);
            }
        }     
        public class LightsForm : Form
        {
            bool[] lights = new bool[3];

            public LightsForm()
            {
                DoubleBuffered = true;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                var d = Math.Min(ClientSize.Width, ClientSize.Height / 3);
                var colors = new[] { Color.Red, Color.Yellow, Color.Green };
                e.Graphics.Clear(Color.White);
                for (int i = 0; i < 3; i++)
                    e.Graphics.FillEllipse(
                        new SolidBrush(lights[i] ? colors[i] : Color.White),
                        ClientSize.Width / 2 - d / 2,
                        i * ClientSize.Height / 3 + ClientSize.Height / 6 - d / 2,
                        d,
                        d);
            }

            public void LightOn(int lightColor)
            {
                lights[lightColor] = true;
                BeginInvoke(new Action(Invalidate));
            }

            public void LightOff(int lightColor)
            {
                lights[lightColor] = false;
                BeginInvoke(new Action(Invalidate));
            }

            [STAThread]
            //[Test]
            //[Explicit]
            public static void Main()
            {
                Application.EnableVisualStyles();
                form = new LightsForm();
                new Action(Control).BeginInvoke(null, null);
                Application.Run(form);
            }
        }
        
    }
    
}
