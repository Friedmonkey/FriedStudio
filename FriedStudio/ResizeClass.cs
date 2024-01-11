//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace ScuffedScri
//{
//    class ResizeClass : UserControl
//    {
//        //public ResizeClass()
//        //{
//        //    InitializeComponent();
//        //}

//        // Hotspot rectangles
//        private Rectangle topLeftRect;
//        private Rectangle topRightRect;
//        private Rectangle bottomLeftRect;
//        private Rectangle bottomRightRect;

//        private Rectangle topRect;
//        private Rectangle bottomRect;
//        private Rectangle leftRect;
//        private Rectangle rightRect;
//        private Rectangle storedOposite;

//        // Hotspot mousedown flags
//        private bool topLeftSelected = false;
//        private bool topRightSelected = false;
//        private bool bottomLeftSelected = false;
//        private bool bottomRightSelected = false;

//        private bool TopSelected = false;
//        private bool BottomSelected = false;
//        private bool LeftSelected = false;
//        private bool RightSelected = false;

//        private int minimalWidth = 25;
//        private int minimalHeight = 25;

//        public int MinimalWidth
//        {
//            get { return minimalWidth; }
//            set { minimalWidth = value; }
//        }
//        public int MinimalHeight
//        {
//            get { return minimalHeight; }
//            set { minimalHeight = value; }
//        }



//        private bool allowTopLeft = true;
//        private bool allowTopRight = true;
//        private bool allowBottomLeft = true;
//        private bool allowBottomRight = true;
//        private bool allowTop = true;
//        private bool allowBottom = true;
//        private bool allowLeft = true;
//        private bool allowRight = true;
//        private bool allowMove = true;

//        public bool AllowTopLeft
//        {
//            get { return allowTopLeft; }
//            set { allowTopLeft = value; }
//        }
//        public bool AllowTopRight
//        {
//            get { return allowTopRight; }
//            set { allowTopRight = value; }
//        }
//        public bool AllowBottomLeft
//        {
//            get { return allowBottomLeft; }
//            set { allowBottomLeft = value; }
//        }
//        public bool AllowBottomRight
//        {
//            get { return allowBottomRight; }
//            set { allowBottomRight = value; }
//        }
//        public bool AllowTop
//        {
//            get { return allowTop; }
//            set { allowTop = value; }
//        }
//        public bool AllowBottom
//        {
//            get { return allowBottom; }
//            set { allowBottom = value; }
//        }
//        public bool AllowLeft
//        {
//            get { return allowLeft; }
//            set { allowLeft = value; }
//        }
//        public bool AllowRight
//        {
//            get { return allowRight; }
//            set { allowRight = value; }
//        }
//        public bool AllowMove
//        {
//            get { return allowMove; }
//            set { allowMove = value; }
//        }

//        // Individual offset variables
//        private int topLeftxOffset;
//        private int topLeftyOffset;
//        private int topRightxOffset;
//        private int topRightyOffset;
//        private int bottomRightxOffset;
//        private int bottomRightyOffset;
//        private int bottomLeftxOffset;
//        private int bottomLeftyOffset;

//        private int topyOffset;
//        private int bottomyOffset;
//        private int leftyOffset;
//        private int rightyOffset;
//        private int topxOffset;
//        private int bottomxOffset;
//        private int leftxOffset;
//        private int rightxOffset;


//        private int mCentralXOffset;
//        private int mCentralYOffset;

//        private void ResizableControl_Paint(object sender, PaintEventArgs e)
//        {
//            //base.OnPaint(e);

//            // Build each hotspot needed based upon the size of the control
//            int rectSize = 8;
//            topLeftRect = new Rectangle(0, 0, rectSize, rectSize);
//            topRightRect = new Rectangle(Width - (rectSize + 1), 0, rectSize, rectSize);
//            bottomLeftRect = new Rectangle(0, Height - (rectSize + 1), rectSize, rectSize);
//            bottomRightRect = new Rectangle(Width - (rectSize + 1), Height - (rectSize + 1), rectSize, rectSize);

//            topRect = new Rectangle((Width / 2) - ((rectSize + 1) / 2), 0, rectSize, rectSize);
//            bottomRect = new Rectangle((Width / 2) - ((rectSize + 1) / 2), Height - (rectSize + 1), rectSize, rectSize);
//            leftRect = new Rectangle(0, (Height / 2) - ((rectSize + 1) / 2), rectSize, rectSize);
//            rightRect = new Rectangle(Width - (rectSize + 1), (Height / 2) - ((rectSize + 1) / 2), rectSize, rectSize);

//            List<Rectangle> rects = new List<Rectangle>();
//            if (allowTopLeft)
//                rects.Add(topLeftRect);
//            if (allowTopRight)
//                rects.Add(topRightRect);
//            if (allowBottomLeft)
//                rects.Add(bottomLeftRect);
//            if (allowBottomRight)
//                rects.Add(bottomRightRect);
//            if (allowTop)
//                rects.Add(topRect);
//            if (allowBottom)
//                rects.Add(bottomRect);
//            if (allowLeft)
//                rects.Add(leftRect);
//            if (allowRight)
//                rects.Add(rightRect);


//            foreach (var rect in rects)
//            {
//                //draw white square
//                e.Graphics.FillRectangle(Pens.White.Brush, rect);

//                // Draw each rect onto the surface of the control
//                //draw black border wound square
//                e.Graphics.DrawRectangle(Pens.Black, rect);
//            }
//        }

//        private void ResizableControl_MouseDown(object sender, MouseEventArgs e)
//        {
//            //base.OnMouseDown(e);

//            Parent.SuspendLayout();

//            // When the user presses down on the left mouse button store 
//            // some critical numbers for use during the mouse move.
//            if (topLeftRect.Contains(e.Location))
//            {
//                topLeftSelected = true;
//                //from click pos to 0,0
//                topLeftxOffset = e.X;
//                topLeftyOffset = e.Y;
//                //from 0,0 to opposite corner of click pos
//                storedOposite.X = (Location.X + Width);
//                storedOposite.Y = (Location.Y + Height);
//            }
//            else if (topRightRect.Contains(e.Location))
//            {
//                topRightSelected = true;
//                //from click pos to 0,0
//                topRightxOffset = Width - e.X;
//                topRightyOffset = e.Y;
//                //from 0,0 to opposite corner of click pos
//                storedOposite.X = (Location.X);
//                storedOposite.Y = (Location.Y + Height);
//            }
//            else if (bottomLeftRect.Contains(e.Location))
//            {
//                bottomLeftSelected = true;
//                //from click pos to 0,0
//                bottomLeftxOffset = e.X;
//                bottomLeftyOffset = Height - e.Y;
//                //from 0,0 to opposite corner of click pos
//                storedOposite.X = (Location.X + Width);
//                storedOposite.Y = (Location.Y);
//            }
//            else if (bottomRightRect.Contains(e.Location))
//            {
//                bottomRightSelected = true;
//                //from click pos to 0,0
//                bottomRightxOffset = Width - e.X;
//                bottomRightxOffset = Height - e.Y;
//                bottomRightyOffset = 0;
//            }
//            //our stuff
//            else if (topRect.Contains(e.Location))
//            {
//                TopSelected = true;
//                //from click pos to 0,0
//                topxOffset = e.X - (Width / 2);
//                topyOffset = e.Y;
//                //from 0,0 to opposite corner of click pos
//                storedOposite.X = (Location.X + (Width / 2));
//                storedOposite.Y = (Location.Y + Height);
//            }
//            else if (bottomRect.Contains(e.Location))
//            {
//                BottomSelected = true;
//                //from click pos to 0,0
//                bottomxOffset = e.X - (Width / 2);
//                bottomyOffset = e.Y - Height;
//                //from 0,0 to opposite corner of click pos
//                storedOposite.X = (Location.X + (Width / 2));
//                storedOposite.Y = (Location.Y);
//            }
//            else if (leftRect.Contains(e.Location))
//            {
//                LeftSelected = true;
//                //from click pos to 0,0
//                leftxOffset = e.X;
//                leftyOffset = e.Y - (Height / 2);
//                //from 0,0 to opposite corner of click pos
//                storedOposite.X = (Location.X + Width);
//                storedOposite.Y = (Location.Y + (Height / 2));
//            }
//            else if (rightRect.Contains(e.Location))
//            {
//                RightSelected = true;
//                //from click pos to 0,0
//                rightxOffset = e.X - Width;
//                rightyOffset = e.Y - (Height / 2);
//                //from 0,0 to opposite corner of click pos
//                storedOposite.X = (Location.X);
//                storedOposite.Y = (Location.Y + (Height / 2));
//            }

//            else//clicked on anyting BUT the handles
//            {
//                mCentralXOffset = e.X;
//                mCentralYOffset = e.Y;
//            }


//        }

//        private void ResizableControl_MouseUp(object sender, MouseEventArgs e)
//        {
//            topLeftSelected = false;
//            topRightSelected = false;
//            bottomLeftSelected = false;
//            bottomRightSelected = false;

//            TopSelected = false;
//            BottomSelected = false;
//            LeftSelected = false;
//            RightSelected = false;

//            Parent.ResumeLayout(); //false?
//        }

//        //private void ResizableControl_MouseMove(object sender, MouseEventArgs e)
//        //{

//        //}
//        private void ResizableControl_MouseMove(object sender, MouseEventArgs e)
//        {
//            // Set the proper mouse pointer for each hotspot
//            if (topLeftRect.Contains(e.Location) && allowTopLeft)
//            {
//                Cursor = Cursors.SizeNWSE;
//            }
//            else if (topRightRect.Contains(e.Location) && allowTopRight)
//            {
//                Cursor = Cursors.SizeNESW;
//            }
//            else if (bottomLeftRect.Contains(e.Location) && allowBottomLeft)
//            {
//                Cursor = Cursors.SizeNESW;
//            }
//            else if (bottomRightRect.Contains(e.Location) && allowBottomRight)
//            {
//                Cursor = Cursors.SizeNWSE;
//            }
//            //our stuff
//            else if (topRect.Contains(e.Location) && allowTop)
//            {
//                Cursor = Cursors.SizeNS;
//            }
//            else if (bottomRect.Contains(e.Location) && allowBottom)
//            {
//                Cursor = Cursors.SizeNS;
//            }
//            else if (leftRect.Contains(e.Location) && allowLeft)
//            {
//                Cursor = Cursors.SizeWE;
//            }
//            else if (rightRect.Contains(e.Location) && allowRight)
//            {
//                Cursor = Cursors.SizeWE;
//            }
//            else
//            {
//                if (allowMove)
//                    Cursor = Cursors.SizeAll;
//                else
//                    Cursor = Cursors.Default;
//            }

//            //minimalWidth = 100;
//            //minimalHeight = 100;

//            // React to the movement only when the left button is held down.
//            if (e.Button == MouseButtons.Left)
//            {
//                if (topLeftSelected == true && allowTopLeft)
//                {
//                    Point clientPosition = Parent.PointToClient(Cursor.Position);
//                    Point adjustedLocation = new Point(clientPosition.X - topLeftxOffset, clientPosition.Y - topLeftyOffset);
//                    int width = storedOposite.X - adjustedLocation.X;
//                    int height = storedOposite.Y - adjustedLocation.Y;

//                    if ((width > minimalWidth) || (height > minimalHeight))
//                    {
//                        Location = adjustedLocation;
//                        if (width > minimalWidth)
//                            Width = width;
//                        if (height > minimalHeight)
//                            Height = height;
//                        Invalidate();
//                    }
//                }
//                else if (topRightSelected == true && allowTopRight)
//                {
//                    Point clientPosition = Parent.PointToClient(Cursor.Position);
//                    Point adjustedLocation = new Point(Location.X, clientPosition.Y - topRightyOffset);
//                    int width = (clientPosition.X + topRightxOffset) - Location.X;
//                    int height = storedOposite.Y - adjustedLocation.Y;

//                    if ((width > minimalWidth) || (height > minimalHeight))
//                    {
//                        Location = adjustedLocation;
//                        if (width > minimalWidth)
//                            Width = width;
//                        if (height > minimalHeight)
//                            Height = height;
//                        Invalidate();
//                    }
//                }
//                else if (bottomLeftSelected == true && allowBottomLeft)
//                {
//                    Point clientPosition = Parent.PointToClient(Cursor.Position);
//                    Point adjustedLocation = new Point(clientPosition.X - bottomLeftxOffset, Location.Y);
//                    int width = (storedOposite.X + bottomLeftxOffset) - clientPosition.X;
//                    int height = (clientPosition.Y + bottomLeftyOffset) - Location.Y;

//                    if ((width > minimalWidth) || (height > minimalHeight))
//                    {
//                        Location = adjustedLocation;
//                        if (width > minimalWidth)
//                            Width = width;
//                        if (height > minimalHeight)
//                            Height = height;
//                        Invalidate();
//                    }
//                }
//                else if (bottomRightSelected == true && allowBottomRight)
//                {
//                    int width = (e.X + bottomRightxOffset);
//                    int height = (e.Y + bottomRightyOffset);
//                    if ((width > minimalWidth) || (height > minimalHeight))
//                    {
//                        if (width > minimalWidth)
//                            Width = width;
//                        if (height > minimalHeight)
//                            Height = height;
//                        Invalidate();
//                    }
//                }
//                //our stuff
//                else if (TopSelected == true && allowTop)
//                {
//                    Point clientPosition = Parent.PointToClient(Cursor.Position);
//                    Point adjustedLocation = new Point(Location.X, clientPosition.Y - topyOffset);
//                    int height = storedOposite.Y - adjustedLocation.Y;

//                    if (height > minimalHeight)
//                    {
//                        Location = adjustedLocation;
//                        Height = height;

//                        Invalidate();
//                    }
//                }

//                else if (BottomSelected == true && allowBottom)
//                {
//                    Point clientPosition = Parent.PointToClient(Cursor.Position);
//                    int height = (clientPosition.Y + bottomyOffset) - Location.Y;

//                    if (height > minimalHeight)
//                    {
//                        Height = height;

//                        Invalidate();
//                    }
//                }
//                else if (LeftSelected == true && allowLeft)
//                {
//                    Point clientPosition = Parent.PointToClient(Cursor.Position);
//                    Point adjustedLocation = new Point(clientPosition.X - leftxOffset, Location.Y);
//                    int width = storedOposite.X - adjustedLocation.X;

//                    if (width > minimalWidth)
//                    {
//                        Location = adjustedLocation;
//                        Width = width;

//                        Invalidate();
//                    }
//                }

//                else if (RightSelected == true && allowRight)
//                {
//                    Point clientPosition = Parent.PointToClient(Cursor.Position);
//                    int width = (clientPosition.X + rightxOffset) - Location.X;

//                    if (width > minimalWidth)
//                    {
//                        Width = width;

//                        Invalidate();
//                    }
//                }

//                else
//                {
//                    if (allowMove)
//                    {
//                        Point clientPosition = Parent.PointToClient(Cursor.Position);
//                        Point adjustedLocation = new Point(clientPosition.X - mCentralXOffset, clientPosition.Y - mCentralYOffset);
//                        Location = adjustedLocation;
//                    }
//                }
//            }
//        }

//        //private void InitializeComponent()
//        //{
//        //    this.SuspendLayout();
//        //    // 
//        //    // ResizeClass
//        //    // 
//        //    this.Name = "ResizeClass";
//        //    this.Load += new System.EventHandler(this.ResizeClass_Load);
//        //    this.ResumeLayout(false);

//        //}

//        //private void ResizeClass_Load(object sender, EventArgs e)
//        //{

//        //}
//    }
//}
