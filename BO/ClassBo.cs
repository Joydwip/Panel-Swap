using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace BO
{
    public class ClassBo
    {
        Point a = new Point(81, 42);
        Point b = new Point(423, 42);
        Point c = new Point(81, 257);
        Point d = new Point(423, 257);


        public int getPanel(Point p, Panel p1, Panel p2, Panel p3, Panel p4)
        {
            if (p==p1.Location)
                return 1;
            if (p==p2.Location)
                return 2;
            if (p==p3.Location)
                return 3;
            if (p==p4.Location)
                return 4;
            else
                return 0;
        }

        public void swapPanel(Point p, Panel thatPanel, Panel p1, Panel p2, Panel p3, Panel p4, int pp)
        {
            if(pp==1)
            {
                thatPanel.Location = p1.Location;
                p1.Location = p;
            }
            if(pp==2)
            {
                thatPanel.Location = p2.Location;
                p2.Location = p;
            }
            if (pp == 3)
            {
                thatPanel.Location = p3.Location;
                p3.Location = p;
            }
            if (pp == 4)
            {
                thatPanel.Location = p4.Location;
                p4.Location = p;
            }
        }

        public void swap(Panel thatPanel, Panel p1, Panel p2, Panel p3, Panel p4, Point pan)
        {
            if (thatPanel.Location.X > 0 && thatPanel.Location.Y > 219 && thatPanel.Location.X < 362 && thatPanel.Location.Y < 461)
            {
                int p = getPanel(c, p1, p2, p3, p4);
                swapPanel(pan, thatPanel, p1, p2, p3, p4, p);

            }

            else if (thatPanel.Location.X > 362 && thatPanel.Location.Y > 0 && thatPanel.Location.X < 742 && thatPanel.Location.Y < 219)
            {
                int p = getPanel(b, p1, p2, p3, p4);
                swapPanel(pan, thatPanel, p1, p2, p3, p4, p);

            }

            else if (thatPanel.Location.X > 362 && thatPanel.Location.Y > 219 && thatPanel.Location.X < 742 && thatPanel.Location.Y < 461)
            {
                int p = getPanel(d, p1, p2, p3, p4);
                swapPanel(pan, thatPanel, p1, p2, p3, p4, p);
            }

            else if (thatPanel.Location.X > 0 && thatPanel.Location.Y > 0 && thatPanel.Location.X < 362 && thatPanel.Location.Y < 219)
            {

                int p = getPanel(a, p1, p2, p3, p4);
                swapPanel(pan, thatPanel, p1, p2, p3, p4, p);

            }

            else
                thatPanel.Location = pan;
        }

    }
}
