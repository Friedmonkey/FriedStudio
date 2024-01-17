using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ScuffedScri.Form1;

namespace ScuffedScri
{
    public partial class ResizableControl : UserControl
    {
        public ResizableControl()
        {
            InitializeComponent();
        }

        // Hotspot rectangles
        private Rectangle topLeftRect;
        private Rectangle topRightRect;
        private Rectangle bottomLeftRect;
        private Rectangle bottomRightRect;

        private Rectangle topRect;
        private Rectangle bottomRect;
        private Rectangle leftRect;
        private Rectangle rightRect;
        private Rectangle storedOposite;

        //private Graphics graphs = new Graphics();

        // Hotspot mousedown flags
        private bool topLeftSelected = false;
        private bool topRightSelected = false;
        private bool bottomLeftSelected = false;
        private bool bottomRightSelected = false;

        private bool TopSelected = false;
        private bool BottomSelected = false;
        private bool LeftSelected = false;
        private bool RightSelected = false;

        private int minimalWidth = 35;
        private int minimalHeight = 35;

        public int MinimalWidth
        {
            get { return minimalWidth; }
            set { minimalWidth = value; }
        }
        public int MinimalHeight
        {
            get { return minimalHeight; }
            set { minimalHeight = value; }
        }

        private fakeControlType type = fakeControlType.Empty;

        public fakeControlType ControlType
        {
            get { return type; }
            set { type = value; }
        }

        private bool allowTopLeft = true;
        private bool allowTopRight = true;
        private bool allowBottomLeft = true;
        private bool allowBottomRight = true;
        private bool allowTop = true;
        private bool allowBottom = true;
        private bool allowLeft = true;
        private bool allowRight = true;
        private bool allowMove = true;

        private bool enabled = true;

        public bool AllowTopLeft
        {
            get { return allowTopLeft; }
            set { allowTopLeft = value; }
        }
        public bool AllowTopRight
        {
            get { return allowTopRight; }
            set { allowTopRight = value; }
        }
        public bool AllowBottomLeft
        {
            get { return allowBottomLeft; }
            set { allowBottomLeft = value; }
        }
        public bool AllowBottomRight
        {
            get { return allowBottomRight; }
            set { allowBottomRight = value; }
        }
        public bool AllowTop
        {
            get { return allowTop; }
            set { allowTop = value; }
        }
        public bool AllowBottom
        {
            get { return allowBottom; }
            set { allowBottom = value; }
        }
        public bool AllowLeft
        {
            get { return allowLeft; }
            set { allowLeft = value; }
        }
        public bool AllowRight
        {
            get { return allowRight; }
            set { allowRight = value; }
        }
        public bool AllowMove
        {
            get { return allowMove; }
            set { allowMove = value; }
        }


        public bool AllowAll
        {
            get 
            {
                if
                    (
                        allowTopLeft &&
                        allowTopRight &&
                        allowBottomLeft &&
                        allowBottomRight &&
                        allowTop &&
                        allowBottom &&
                        allowLeft &&
                        allowRight &&
                        allowMove
                    )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set 
            {
                allowTopLeft = value;
                allowTopRight = value;
                allowBottomLeft = value;
                allowBottomRight = value;
                allowTop = value;
                allowBottom = value;
                allowLeft = value;
                allowRight = value;
                allowMove = value;
            }
        }


        public bool FakeEnabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        // Individual offset variables
        private int topLeftxOffset;
        private int topLeftyOffset;
        private int topRightxOffset;
        private int topRightyOffset;
        private int bottomRightxOffset;
        private int bottomRightyOffset;
        private int bottomLeftxOffset;
        private int bottomLeftyOffset;

        private int topyOffset;
        private int bottomyOffset;
        private int leftyOffset;
        private int rightyOffset;
        private int topxOffset;
        private int bottomxOffset;
        private int leftxOffset;
        private int rightxOffset;


        private int mCentralXOffset;
        private int mCentralYOffset;

        public List<Control> controls = new List<Control>();

        public void addPanelControl(Control control) 
        {
            panel1.Controls.Add(control);
            controls.Add(control);
        }
        public void DeleteControl(Control control)
        {
            panel1.Controls.Remove(control);
            controls.Remove(control);
            //control.Dispose();
        }
        public void ClearControls()
        {
            panel1.Controls.Clear();
            controls.Clear();
            //control.Dispose();
        }

        public Control getPanel()
        {
            return this.panel1;
        }

        public Control getControl() 
        {
            if (this.type != fakeControlType.Empty) 
            {
                if (panel1.Controls.Count > 0)
                    return panel1.Controls[0];
            }
            return null;
        }
        public void changeControl<Value>(string property,Value val,bool mainCont = false) 
        {
            Control cont;
            if (mainCont)
                cont = this;
            else
                cont = getControl();

            if (cont == null)
                return;
            var prop = cont.GetType().GetProperty(property);
            prop.SetValue(cont, val);
        }
        //public string getControlProperty<Value>(string property, bool mainCont = false)
        //{
        //    Control cont;
        //    if (mainCont)
        //        cont = this;
        //    else
        //        cont = getControl();

        //    if (cont == null)
        //        return;

        //    var prop = cont.GetType().GetProperty(property);
        //    prop.GetValue(cont);
        //}
        public string getControlPropertyValue(string property, bool mainCont = false)
        {
            Control cont;
            if (mainCont)
                cont = this;
            else
                cont = getControl();

            if (cont == null)
                return "";
            try
            {
                var prop = cont.GetType().GetProperty(property);
                return (string)prop.GetValue(cont);
            }
            catch 
            {
                return "catch exeption";
            }
        }



        public void ForceLoad() 
        {
            switch (type)
            {
                case fakeControlType.Empty:
                    break;
                case fakeControlType.Label:

                    //allowTopLeft = false;

                    //allowTopRight = false;
                    //allowBottomLeft = false;
                    //allowBottomRight = false;
                    //allowTop = false;
                    //allowBottom = false;
                    //allowLeft = false;
                    //allowRight = false;
                    //enabled && allowMove = false;
                    AllowAll = false;
                    allowRight = true;
                    allowMove = true;


                    Label label = new Label();
                    label.BackColor = System.Drawing.Color.Transparent;
                    label.Dock = System.Windows.Forms.DockStyle.Fill;
                    label.Location = new System.Drawing.Point(2, 2);
                    label.Margin = new System.Windows.Forms.Padding(5);
                    label.Name = "label";
                    label.Size = new System.Drawing.Size(131, 131);
                    label.TabIndex = 0;
                    label.Text = "label";
                    label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                    this.Size = new Size(MinimalWidth+30,minimalHeight+10);
                    ////panel1.BackColor = Color.Transparent;
                    //panel1.BackColor = Color.FromArgb(188,255,255,255);
                    //panel1.BorderStyle = BorderStyle.None;

                    //this.BackColor = Color.FromArgb(188, 255, 255, 255);
                    //this.BorderStyle = BorderStyle.None;


                    //panel1.Visible = false;

                    //this.SendToBack();
                    //this.UpdateZOrder();

                    label.MouseDown += ResizableControl_MouseDown;
                    label.MouseUp += ResizableControl_MouseUp;
                    label.MouseMove += ResizableControl_MouseMove;
                    label.Click += ResizableControl_Click;

                    panel1.Controls.Add(label);
                    break;
                case fakeControlType.Button:

                    Button button = new Button();
                    //button.BackColor = System.Drawing.Color.Transparent;
                    button.Dock = System.Windows.Forms.DockStyle.Fill;
                    button.Location = new System.Drawing.Point(2, 2);
                    button.Margin = new System.Windows.Forms.Padding(5);
                    button.Name = "label";
                    button.Size = new System.Drawing.Size(131, 131);
                    button.TabIndex = 0;
                    button.Text = "label";
                    button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    this.Size = new Size(MinimalWidth + 30, minimalHeight + 10);


                    button.MouseDown += ResizableControl_MouseDown;
                    button.MouseUp += ResizableControl_MouseUp;
                    button.MouseMove += ResizableControl_MouseMove;
                    button.Click += ResizableControl_Click;

                    panel1.Controls.Add(button);
                    break;
                case fakeControlType.Checkbox:
                    AllowAll = false;
                    allowRight = true;
                    allowMove = true;

                    CheckBox checkbox = new CheckBox();
                    //button.BackColor = System.Drawing.Color.Transparent;
                    checkbox.Dock = System.Windows.Forms.DockStyle.Fill;
                    checkbox.Location = new System.Drawing.Point(2, 2);
                    checkbox.Margin = new System.Windows.Forms.Padding(5);
                    checkbox.Name = "textbox";
                    checkbox.Size = new System.Drawing.Size(131, 131);
                    checkbox.TabIndex = 0;
                    checkbox.Text = "";
                    //textbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    this.Size = new Size(50, minimalHeight + 10);


                    checkbox.MouseDown += ResizableControl_MouseDown;
                    checkbox.MouseUp += ResizableControl_MouseUp;
                    checkbox.MouseMove += ResizableControl_MouseMove;
                    checkbox.Click += ResizableControl_Click;

                    panel1.Controls.Add(checkbox);
                    break;
                case fakeControlType.Textbox:

                    AllowAll = false;
                    allowLeft = true;
                    allowRight = true;
                    allowMove = true;

                    TextBox textbox = new TextBox();
                    //button.BackColor = System.Drawing.Color.Transparent;
                    textbox.Dock = System.Windows.Forms.DockStyle.Fill;
                    textbox.Location = new System.Drawing.Point(2, 2);
                    textbox.Margin = new System.Windows.Forms.Padding(5);
                    textbox.Name = "textbox";
                    textbox.Size = new System.Drawing.Size(131, 131);
                    textbox.TabIndex = 0;
                    textbox.Text = "";
                    //textbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    this.Size = new Size(50, minimalHeight + 10);


                    textbox.MouseDown += ResizableControl_MouseDown;
                    textbox.MouseUp += ResizableControl_MouseUp;
                    textbox.MouseMove += ResizableControl_MouseMove;
                    textbox.Click += ResizableControl_Click;

                    panel1.Controls.Add(textbox);
                    break;
                default:
                    break;
            }
        }

        private void ResizableControl_Load(object sender, EventArgs e)
        {
            ForceLoad();
        }
        private void ResizableControl_Paint(object sender, PaintEventArgs e)
        {
            DrawAnchors(e.Graphics);
            ////base.OnPaint(e);

            ////Console.WriteLine(sender.ToString());
            ////Console.WriteLine(e.ToString());
            ////Console.WriteLine(e.Graphics.ToString());


            //// Build each hotspot needed based upon the size of the control
            //int rectSize = 8;
            //topLeftRect = new Rectangle(0, 0, rectSize, rectSize);
            //topRightRect = new Rectangle(Width - (rectSize+1), 0, rectSize, rectSize);
            //bottomLeftRect = new Rectangle(0, Height - (rectSize+1), rectSize, rectSize);
            //bottomRightRect = new Rectangle(Width - (rectSize + 1), Height - (rectSize+1), rectSize, rectSize);

            //topRect = new Rectangle((Width/2)-((rectSize + 1)/2), 0, rectSize, rectSize);
            //bottomRect = new Rectangle((Width/2)-((rectSize + 1) / 2), Height-(rectSize + 1), rectSize, rectSize);
            //leftRect = new Rectangle(0, (Height/2)- ((rectSize + 1) / 2), rectSize, rectSize);
            //rightRect = new Rectangle(Width- (rectSize + 1), (Height / 2)- ((rectSize + 1) / 2), rectSize, rectSize);

            //List<Rectangle> rects = new List<Rectangle>();
            //if (enabled && allowTopLeft)
            //    rects.Add(topLeftRect);
            //if (enabled && allowTopRight)
            //    rects.Add(topRightRect);
            //if (enabled && allowBottomLeft)
            //    rects.Add(bottomLeftRect);
            //if (enabled && allowBottomRight)
            //    rects.Add(bottomRightRect);
            //if (enabled && allowTop)
            //    rects.Add(topRect);
            //if (enabled && allowBottom)
            //    rects.Add(bottomRect);
            //if (enabled && allowLeft)
            //    rects.Add(leftRect);
            //if (enabled && allowRight)
            //    rects.Add(rightRect);


            //foreach (var rect in rects)
            //{
            //    //draw white square
            //    e.Graphics.FillRectangle(Pens.White.Brush, rect);

            //    // Draw each rect onto the surface of the control
            //    //draw black border wound square
            //    e.Graphics.DrawRectangle(Pens.Black, rect);
            //}
        }

        public void DrawAnchors(Graphics e)
        {

            // Build each hotspot needed based upon the size of the control
            int rectSize = 8;
            topLeftRect = new Rectangle(0, 0, rectSize, rectSize);
            topRightRect = new Rectangle(Width - (rectSize + 1), 0, rectSize, rectSize);
            bottomLeftRect = new Rectangle(0, Height - (rectSize + 1), rectSize, rectSize);
            bottomRightRect = new Rectangle(Width - (rectSize + 1), Height - (rectSize + 1), rectSize, rectSize);

            topRect = new Rectangle((Width / 2) - ((rectSize + 1) / 2), 0, rectSize, rectSize);
            bottomRect = new Rectangle((Width / 2) - ((rectSize + 1) / 2), Height - (rectSize + 1), rectSize, rectSize);
            leftRect = new Rectangle(0, (Height / 2) - ((rectSize + 1) / 2), rectSize, rectSize);
            rightRect = new Rectangle(Width - (rectSize + 1), (Height / 2) - ((rectSize + 1) / 2), rectSize, rectSize);

            List<Rectangle> rects = new List<Rectangle>();
            if (enabled && allowTopLeft)
                rects.Add(topLeftRect);
            if (enabled && allowTopRight)
                rects.Add(topRightRect);
            if (enabled && allowBottomLeft)
                rects.Add(bottomLeftRect);
            if (enabled && allowBottomRight)
                rects.Add(bottomRightRect);
            if (enabled && allowTop)
                rects.Add(topRect);
            if (enabled && allowBottom)
                rects.Add(bottomRect);
            if (enabled && allowLeft)
                rects.Add(leftRect);
            if (enabled && allowRight)
                rects.Add(rightRect);

            if (rects.Count == 0) 
            {
                e.Clear(this.Parent.BackColor);
                //e.Clear(Color.Black);
                return;
            }

            foreach (var rect in rects)
            {
                //draw white square
                e.FillRectangle(Pens.White.Brush, rect);

                // Draw each rect onto the surface of the control
                //draw black border wound square
                e.DrawRectangle(Pens.Black, rect);
            }
        }

        private void ResizableControl_MouseDown(object sender, MouseEventArgs e)
        {
            //base.OnMouseDown(e);

            Parent.SuspendLayout();

            // When the user presses down on the left mouse button store 
            // some critical numbers for use during the mouse move.
            if (topLeftRect.Contains(e.Location) && enabled && allowTopLeft)
            {
                topLeftSelected = true;
                //from click pos to 0,0
                topLeftxOffset = e.X;
                topLeftyOffset = e.Y;
                //from 0,0 to opposite corner of click pos
                storedOposite.X = (Location.X + Width);
                storedOposite.Y = (Location.Y + Height);
            }
            else if (topRightRect.Contains(e.Location) && enabled && allowTopRight)
            {
                topRightSelected = true;
                //from click pos to 0,0
                topRightxOffset = Width - e.X;
                topRightyOffset = e.Y;
                //from 0,0 to opposite corner of click pos
                storedOposite.X = (Location.X);
                storedOposite.Y = (Location.Y + Height);
            }
            else if (bottomLeftRect.Contains(e.Location) &&enabled && allowBottomLeft)
            {
                bottomLeftSelected = true;
                //from click pos to 0,0
                bottomLeftxOffset = e.X;
                bottomLeftyOffset = Height - e.Y;
                //from 0,0 to opposite corner of click pos
                storedOposite.X = (Location.X + Width);
                storedOposite.Y = (Location.Y);
            }
            else if (bottomRightRect.Contains(e.Location) &&enabled && allowBottomRight)
            {
                bottomRightSelected = true;
                //from click pos to 0,0
                bottomRightxOffset = Width - e.X;
                bottomRightxOffset = Height - e.Y;
                bottomRightyOffset = 0;
            }
            //our stuff
            else if (topRect.Contains(e.Location) && enabled && allowTop)
            {
                TopSelected = true;
                //from click pos to 0,0
                topxOffset = e.X - (Width / 2);
                topyOffset = e.Y;
                //from 0,0 to opposite corner of click pos
                storedOposite.X = (Location.X + (Width/2));
                storedOposite.Y = (Location.Y + Height);
            }
            else if (bottomRect.Contains(e.Location) && enabled && allowBottom)
            {
                BottomSelected = true;
                //from click pos to 0,0
                bottomxOffset = e.X - (Width / 2);
                bottomyOffset = e.Y - Height;
                //from 0,0 to opposite corner of click pos
                storedOposite.X = (Location.X + (Width/2));
                storedOposite.Y = (Location.Y);
            }
            else if (leftRect.Contains(e.Location) && enabled && allowLeft)
            {
                LeftSelected = true;
                //from click pos to 0,0
                leftxOffset = e.X;
                leftyOffset = e.Y - (Height / 2);
                //from 0,0 to opposite corner of click pos
                storedOposite.X = (Location.X + Width);
                storedOposite.Y = (Location.Y + (Height/2));
            }
            else if (rightRect.Contains(e.Location) && enabled && allowRight)
            {
                RightSelected = true;
                //from click pos to 0,0
                rightxOffset = e.X - Width;
                rightyOffset = e.Y - (Height / 2);
                //from 0,0 to opposite corner of click pos
                storedOposite.X = (Location.X);
                storedOposite.Y = (Location.Y + (Height / 2));
            }

            else//clicked on anyting BUT the handles
            {
                if (enabled && allowMove) 
                {
                    mCentralXOffset = e.X;
                    mCentralYOffset = e.Y;
                }
            }


        }

        private void ResizableControl_MouseUp(object sender, MouseEventArgs e)
        {
            topLeftSelected = false;
            topRightSelected = false;
            bottomLeftSelected = false;
            bottomRightSelected = false;

            TopSelected = false;
            BottomSelected = false;
            LeftSelected = false;
            RightSelected = false;

            Parent.ResumeLayout(); //false?
        }

        //private void ResizableControl_MouseMove(object sender, MouseEventArgs e)
        //{

        //}
        private void ResizableControl_MouseMove(object sender, MouseEventArgs e)
        {
            // Set the proper mouse pointer for each hotspot
            if (topLeftRect.Contains(e.Location) && enabled && allowTopLeft)
            {
                Cursor = Cursors.SizeNWSE;
            }
            else if (topRightRect.Contains(e.Location) && enabled && allowTopRight)
            {
                Cursor = Cursors.SizeNESW;
            }
            else if (bottomLeftRect.Contains(e.Location) && enabled && allowBottomLeft)
            {
                Cursor = Cursors.SizeNESW;
            }
            else if (bottomRightRect.Contains(e.Location) && enabled && allowBottomRight)
            {
                Cursor = Cursors.SizeNWSE;
            }
            //our stuff
            else if (topRect.Contains(e.Location) && enabled && allowTop)
            {
                Cursor = Cursors.SizeNS;
            }
            else if (bottomRect.Contains(e.Location) && enabled && allowBottom)
            {
                Cursor = Cursors.SizeNS;
            }
            else if (leftRect.Contains(e.Location) && enabled && allowLeft)
            {
                Cursor = Cursors.SizeWE;
            }
            else if (rightRect.Contains(e.Location) && enabled && allowRight)
            {
                Cursor = Cursors.SizeWE;
            }
            else
            {
                if (enabled && allowMove)
                    Cursor = Cursors.SizeAll;
                else
                    Cursor = Cursors.Default;
            }

            //minimalWidth = 100;
            //minimalHeight = 100;

            // React to the movement only when the left button is held down.
            if (e.Button == MouseButtons.Left)
            {
                if (topLeftSelected == true && enabled && allowTopLeft)
                {
                    Point clientPosition = Parent.PointToClient(Cursor.Position);
                    Point adjustedLocation = new Point(clientPosition.X - topLeftxOffset, clientPosition.Y - topLeftyOffset);
                    int width = storedOposite.X - adjustedLocation.X;
                    int height = storedOposite.Y - adjustedLocation.Y;

                    if ((width > minimalWidth) || (height > minimalHeight))
                    {
                        Location = adjustedLocation;
                        if (width > minimalWidth) 
                            Width = width;
                        if (height > minimalHeight)
                            Height = height;
                        Invalidate();
                    }
                }
                else if (topRightSelected == true && enabled && allowTopRight)
                {
                    Point clientPosition = Parent.PointToClient(Cursor.Position);
                    Point adjustedLocation = new Point(Location.X, clientPosition.Y - topRightyOffset);
                    int width = (clientPosition.X + topRightxOffset) - Location.X;
                    int height = storedOposite.Y - adjustedLocation.Y;

                    if ((width > minimalWidth) || (height > minimalHeight))
                    {
                        Location = adjustedLocation;
                        if (width > minimalWidth)
                            Width = width;
                        if (height > minimalHeight)
                            Height = height;
                        Invalidate();
                    }
                }
                else if (bottomLeftSelected == true && enabled && allowBottomLeft)
                {
                    Point clientPosition = Parent.PointToClient(Cursor.Position);
                    Point adjustedLocation = new Point(clientPosition.X - bottomLeftxOffset, Location.Y);
                    int width = (storedOposite.X + bottomLeftxOffset) - clientPosition.X;
                    int height = (clientPosition.Y + bottomLeftyOffset) - Location.Y;

                    if ((width > minimalWidth) || (height > minimalHeight))
                    {
                        Location = adjustedLocation;
                        if (width > minimalWidth)
                            Width = width;
                        if (height > minimalHeight)
                            Height = height;
                        Invalidate();
                    }
                }
                else if (bottomRightSelected == true && enabled && allowBottomRight)
                {
                    int width = (e.X + bottomRightxOffset);
                    int height = (e.Y + bottomRightyOffset);
                    if ((width > minimalWidth) || (height > minimalHeight))
                    {
                        if (width > minimalWidth)
                            Width = width;
                        if (height > minimalHeight)
                            Height = height;
                        Invalidate();
                    }
                }
                //our stuff
                else if(TopSelected == true && enabled && allowTop)
                {
                    Point clientPosition = Parent.PointToClient(Cursor.Position);
                    Point adjustedLocation = new Point(Location.X, clientPosition.Y - topyOffset);
                    int height = storedOposite.Y - adjustedLocation.Y;

                    if (height > minimalHeight)
                    {
                        Location = adjustedLocation;
                        Height = height;

                        Invalidate();
                    }
                }
                else if(BottomSelected == true && enabled && allowBottom)
                {
                    Point clientPosition = Parent.PointToClient(Cursor.Position);
                    int height = (clientPosition.Y + bottomyOffset) - Location.Y;

                    if (height > minimalHeight)
                    {
                        Height = height;

                        Invalidate();
                    }
                }
                else if(LeftSelected == true && enabled && allowLeft)
                {
                    Point clientPosition = Parent.PointToClient(Cursor.Position);
                    Point adjustedLocation = new Point(clientPosition.X - leftxOffset, Location.Y);
                    int width = storedOposite.X - adjustedLocation.X;

                    if (width > minimalWidth)
                    {
                        Location = adjustedLocation;
                        Width = width;

                        Invalidate();
                    }
                }

                else if(RightSelected == true && enabled && allowRight)
                {
                    Point clientPosition = Parent.PointToClient(Cursor.Position);
                    int width = (clientPosition.X + rightxOffset) - Location.X;

                    if (width > minimalWidth)
                    {
                        Width = width;

                        Invalidate();
                    }
                }

                else
                {
                    if (enabled && allowMove) 
                    {
                        Point clientPosition = Parent.PointToClient(Cursor.Position);
                        Point adjustedLocation = new Point(clientPosition.X - mCentralXOffset, clientPosition.Y - mCentralYOffset);
                        Location = adjustedLocation;
                    }
                }
            }
        }
        public void reDraw() 
        {
            //call paint function but delayed??
            //this.Invalidate();
            //this.Update();
            //this.Refresh();
            //this.BackColor = Color.Red;
            //this.InvokePaint(this, new PaintEventArgs(this.CreateGraphics(), this.DisplayRectangle));
            Graphics g = this.CreateGraphics();
            DrawAnchors(g);
            //foreach (var cont in controls)
            //{
            //    cont.Update();
            //}
        }
        public void setControlProps(controlProps props) 
        {
            changeControl("Name",props.Name);
            changeControl("Text",props.Text);
            changeControl("Tag",props.Tag);
            changeControl("Enabled",props.Enabled);
            changeControl("BackColor",props.BackColor);
            changeControl("ForeColor",props.ForeColor);

            changeControl("Size",props.Size,true);
            changeControl("Location",props.Location,true);

            switch (props.ControlType)
            {
                case fakeControlType.Empty:
                    break;
                case fakeControlType.Label:
                    break;
                case fakeControlType.Button:
                    break;
                case fakeControlType.Checkbox:
                    changeControl("Checked", props.Checked);

                    break;
                case fakeControlType.Textbox:
                    if (props.Multiline)
                        AllowAll = true;
                    else 
                    {
                        AllowAll = false;
                        allowMove = true;
                        allowLeft = true;
                        allowRight = true;
                    }
                    reDraw();
                    changeControl("Multiline", props.Multiline);

                    break;
                default:
                    break;
            }
        }
        public controlProps getControlProps()
        {
            controlProps props = new controlProps();
            Control cont = this.getControl();
            if (cont == null)
                return null;

            props.Name = cont.Name;
            props.Text = cont.Text;
            props.Tag = cont.Tag.ToString();
            props.Enabled = cont.Enabled;
            props.BackColor = cont.BackColor;
            props.ForeColor = cont.ForeColor;
            props.ControlType = type;

            props.Size = this.Size;
            props.Location = this.Location;

            switch (type)
            {
                case fakeControlType.Empty:
                    break;
                case fakeControlType.Label:
                    break;
                case fakeControlType.Button:
                    break;
                case fakeControlType.Checkbox:
                    props.Checked = (cont as CheckBox).Checked;
                    break;
                case fakeControlType.Textbox:
                    props.Multiline = (cont as TextBox).Multiline;
                    break;
                default:
                    break;
            }

            return props;
        }

        private void ResizableControl_Click(object sender, EventArgs e)
        {
            if (!FakeEnabled)
            {
                //this.BringToFront();
                List<Control> conts;
                if (this.Name == "reForm")
                    conts = controls;
                else
                    conts = (this.Parent.Parent as ResizableControl).controls;


                //i am retared as hell, this thing does not have every instance
                foreach (ResizableControl cont in conts)
                {
                    cont.FakeEnabled = false;
                }
                try
                {
                    if ((this.Parent.Parent as ResizableControl) != null)
                        if ((this.Parent.Parent as ResizableControl).Name == "reForm")
                        {
                            (this.Parent.Parent as ResizableControl).FakeEnabled = false;
                            (this.Parent.Parent as ResizableControl).reDraw();
                        }
                }
                catch { }
                FakeEnabled = true;
                foreach (ResizableControl cont in conts)
                {
                    cont.reDraw();
                }
                this.reDraw();
            }
        }
    }
}
