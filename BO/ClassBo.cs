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



        public Panel getPanel(Point p, Panel thatPanel, Panel p1, Panel p2, Panel p3, Panel p4)
        {
            if (p == p1.Location)
                return p1;
            else if (p == p2.Location)
                return p2;
            else if (p == p3.Location)
                return p3;
            else if (p == p4.Location)
                return p4;
            else
                return thatPanel;
        }



        public void swap(Panel thatPanel, Panel p1, Panel p2, Panel p3, Panel p4, Point pan)
        {
            if (( thatPanel.Location.Y > 230 && thatPanel.Location.X < 322 ) && pan != c)
            {
                
                sortedSwap(pan, c, thatPanel, p1, p2, p3, p4);

            }

            else if ((thatPanel.Location.X > 400 && thatPanel.Location.Y < 210) && pan != b)
            {
               
                sortedSwap(pan, b, thatPanel, p1, p2, p3, p4);

            }

            else if (( thatPanel.Location.Y < 210 && thatPanel.Location.X < 322) && pan != a)
            {
                
                sortedSwap(pan, a, thatPanel, p1, p2, p3, p4);
            }

            else if ((thatPanel.Location.X > 400 && thatPanel.Location.Y > 230) && pan != d)
            {

              
                sortedSwap(pan, d, thatPanel, p1, p2, p3, p4);

            }

            else
                thatPanel.Location = pan;
        }

        public void sortedSwap(Point present, Point future, Panel thatPanel, Panel p1, Panel p2, Panel p3, Panel p4)
        {
            Panel pa, pb, pc, pd;
            pa = getPanel(a, thatPanel, p1, p2, p3, p4);
            pb = getPanel(b, thatPanel, p1, p2, p3, p4);
            pc = getPanel(c, thatPanel, p1, p2, p3, p4);
            pd = getPanel(d, thatPanel, p1, p2, p3, p4);

            if (present == a && future == b)
            {
                

                pa.Location = b;
                pb.Location = c;
                pc.Location = d;
                pd.Location = a;
            }
            else if (present == a && future == c)
            {

                pa.Location = c;
                pb.Location = b;
                pc.Location = d;
                pd.Location = a;

            }
            else if (present == a && future == d)
            {
                

                pa.Location = d;
                pb.Location = a;
                pc.Location = b;
                pd.Location = c;

            }

            else if (present == b && future == a)
            {
               

                pa.Location = d;
                pb.Location = a;
                pc.Location = b;
                pd.Location = c;
            }
            else if (present == b && future == c)
            {
                

                pa.Location = b;
                pb.Location = c;
                pc.Location = d;
                pd.Location = a;

            }
            else if (present == b && future == d)
            {
              
                pa.Location = a;
                pb.Location = d;
                pc.Location = b;
                pd.Location = c;

            }

            else if (present == c && future == a)
            {
               

                pa.Location = b;
                pb.Location = c;
                pc.Location = a;
                pd.Location = d;
            }
            else if (present == c && future == b)
            {
              

                pa.Location = d;
                pb.Location = a;
                pc.Location = b;
                pd.Location = c;

            }
            else if (present == c && future == d)
            {
              


                pa.Location = b;
                pb.Location = c;
                pc.Location = d;
                pd.Location = a;

            }

            else if (present == d && future == a)
            {
              

                pa.Location = b;
                pb.Location = c;
                pc.Location = d;
                pd.Location = a;
            }
            else if (present == d && future == b)
            {
                

                pa.Location = a;
                pb.Location = c;
                pc.Location = d;
                pd.Location = b;

            }
            else if (present == d && future == c)
            {
          
                pa.Location = d;
                pb.Location = a;
                pc.Location = b;
                pd.Location = c;

            }


        }
    }

    
}
