using System;
//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;
using System.Drawing;
using System.CodeDom.Compiler;
using System.CodeDom;
using Microsoft.CSharp;
using System.Windows.Media;
using System.Data;
using static ScuffedScri.Form1;
using static ScuffedScri.ResizableControl;

//using System.IO;
//using Microsoft.VisualStudio.Text.Editor;


namespace ScuffedScri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbxTarget.SelectedIndex = 1;
            //tabctrlPages.TabPages.Remove(tabInclude);
        }

        ResizableControl ClickedControl;

        private void bttnCompile_Click(object sender, EventArgs e)
        {
            UpdateDesigner();

            Compile();
        }

        private string CustomParse(string input) 
        {
            return input.Replace("$%ProjectName%$", txtbxName.Text).Replace("$%NameSpace%$", txtbxNameSpace.Text);
        }

        private void Compile() 
        {
            //string[] sources = new string[] 
            //{
            //    CustomParse(txtbxInclude.Text ),
            //    CustomParse(txtbxProgram.Text ),
            //    CustomParse(txtbxDesigner.Text),
            //    CustomParse(txtbxUserCode.Text)
            //};
            FastColoredTextBoxNS.FastColoredTextBox[] SourceBoxes = new FastColoredTextBoxNS.FastColoredTextBox[]
            {   
                //txtbxInclude,
                txtbxProgram,
                txtbxDesigner,
                txtbxUserCode
            };
            //string Code_for_function = txtbxInclude.Text + txtbxProgram.Text + txtbxDesigner.Text + txtbxUserCode.Text;
            //Code_for_function = CustomParse(Code_for_function);

            CSharpCodeProvider c = new CSharpCodeProvider();
            //ICodeCompiler icc = c.CreateCompiler();
            CompilerParameters cp = new CompilerParameters();

            foreach (FastColoredTextBoxNS.FastColoredTextBox source in SourceBoxes)
            {

                foreach (var line in source.Lines)
                {
                    if (line.StartsWith("//include")) 
                    {
                        string usingstatement = line.Replace("//include ", "");
                        usingstatement = usingstatement.Replace(";", ".dll");

                        usingstatement = usingstatement.ToLower();

                        cp.ReferencedAssemblies.Add(usingstatement);

                    }
                }
            }

            List<string> sources = new List<string>();
            foreach (var source in SourceBoxes)
            {
                sources.Add(CustomParse(source.Text));
            }

            //cp.ReferencedAssemblies.Add("system.dll");
            //////cp.ReferencedAssemblies.Add("system.xml.dll");
            //////cp.ReferencedAssemblies.Add("system.data.dll");
            //cp.ReferencedAssemblies.Add("system.windows.forms.dll");
            //cp.ReferencedAssemblies.Add("system.drawing.dll");

            //cp.CompilerOptions = "/t:library";
            cp.CompilerOptions = "/target:"+cmbxTarget.Text.Split('.')[0];

            cp.GenerateInMemory = true;
            cp.GenerateExecutable = true;
            cp.TreatWarningsAsErrors = false;
            cp.WarningLevel = 3;

            string path = /*AppDomain.CurrentDomain.BaseDirectory +*/ "binary/";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            cp.OutputAssembly = path+txtbxName.Text+"."+ cmbxTarget.Text.Split('.')[1];

            //CompilerResults cr = icc.CompileAssemblyFromSource(cp, Code_for_function);
            CompilerResults cr = c.CompileAssemblyFromSource(cp, sources.ToArray());

            if (cr.Errors.Count > 0)
            {
                //MessageBox.Show("ERROR: " + cr.Errors[0].ErrorText,
                //   "Error Generating code", MessageBoxButtons.OK,
                //   MessageBoxIcon.Error);
                foreach (CompilerError error in cr.Errors)
                {
                    if (error.IsWarning)
                    {
                        MessageBox.Show("WARNING: " + error.ErrorText,
                                        "Warning Generating code", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                    else 
                    {
                        MessageBox.Show("ERROR: " + error.ErrorText,
                                        "Error Generating code", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            //System.Reflection.Assembly a = cr.CompiledAssembly;
            //object o = a.CreateInstance("CodeGenarator.CodeGenarator");

            //Type t = o.GetType();
            //MethodInfo mi = t.GetMethod("Main");

            //object s = mi.Invoke(o, null);

            if (checkBox1.Checked) 
            {
                if (cmbxTarget.Text.Split('.')[1] == "dll") 
                {
                    MessageBox.Show("WARNING: " + "Can not run Assembelies with output type = dll",
                                    "Warning Opening", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                System.Diagnostics.ProcessStartInfo PSI = new System.Diagnostics.ProcessStartInfo();
                PSI.FileName = Application.StartupPath + "\\binary\\" + txtbxName.Text + "."+ cmbxTarget.Text.Split('.')[1];
                //PSI.FileName = path + .Text + ".exe";
                PSI.WorkingDirectory = Application.StartupPath;
                System.Diagnostics.Process.Start(PSI);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reForm_SizeChanged(sender,e);

            //reForm.Click += ClickControl;
            reForm.getPanel().Click += ClickControl;
            //reForm.getControl().Click += ClickControl;
        }

        private void bttnDarkMode_Click(object sender, EventArgs e)
        {
            changeTheme(Theme.Dracula);
            //ColorConverter conv = new ColorConverter();
            //txtbxColorCode.BackColor = (Color)conv.ConvertFromString("#282a36");
            //txtbxColorCode.CurrentLineColor = (Color)conv.ConvertFromString("#44475a");
        }
        private void bttnLightMode_Click(object sender, EventArgs e)
        {
            changeTheme(Theme.Light);

        }
        enum Theme 
        {
            Light,
            Dark,
            Dracula
        }
        private void changeTheme(Theme theme) 
        {
            Color Background = Color.Empty;
            Color currentLine = Color.Empty;
            Color changedtLine = Color.Empty;

            Color Foreground = Color.Empty;
            Color Comment = Color.Empty;
            Color carrotColor = Color.Empty;
            Color bookMarkColor = Color.Empty;
            Color linenumebr = Color.Empty;
            Color Green = Color.Empty;
            Color Orange = Color.Empty;
            Color Pink = Color.Empty;
            Color Purple = Color.Empty;
            Color Red = Color.Empty;
            Color Yellow = Color.Empty;
            switch (theme)
            {
                case Theme.Light:
                    Background = Color.White;
                    Foreground = SystemColors.ControlText;
                    Comment = Color.PowderBlue;
                    carrotColor = Color.Black;
                    currentLine = Color.Transparent;
                    changedtLine = Color.Transparent;
                    linenumebr = Color.Teal;
                    break;
                case Theme.Dark:
                    break;
                case Theme.Dracula:
                    Background = "#282a36".ToColor();
                    currentLine = "#44475a".ToColor();
                    Foreground = "#f8f8f2".ToColor();
                    Comment = "#6272a4".ToColor();
                    carrotColor = "#8be9fd".ToColor();
                    bookMarkColor = "#44475a".ToColor();
                    changedtLine = Color.Transparent;
                    linenumebr = "#bd93f9".ToColor();

                    break;
                default:
                    break;
            }
            txtbxProgram.BackColor = Background;
            txtbxProgram.CurrentLineColor = currentLine;
            txtbxProgram.ForeColor = Foreground;
            txtbxProgram.DisabledColor = Comment;
            txtbxProgram.CaretColor = carrotColor;
            txtbxProgram.BookmarkColor = bookMarkColor;
            txtbxProgram.ChangedLineColor = changedtLine;
            txtbxProgram.LineNumberColor = linenumebr;
        }



        private void UpdateDesigner() 
        {
            txtbxDesigner.Text =
@"
//compiler code
namespace $%NameSpace%$
{
    partial class Form1
    {
        // Required designer variable.
        private System.ComponentModel.IContainer components = null;
        // Clean up any resources being used.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            //instantiate all controls
            ";
            foreach (ResizableControl cont in reForm.controls)
            {
                Control control = cont.getControl();
                txtbxDesigner.Text += $"this.{control.Name} = new {control.GetType().FullName}();";
                txtbxDesigner.Text += "\n            ";
            }
            txtbxDesigner.Text += @"
            //suspend Layouts
            this.SuspendLayout();
            ";
            //set control variables
            foreach (ResizableControl cont in reForm.controls)
            {
                Control control = cont.getControl();
                txtbxDesigner.Text += $"this.{control.Name}.Location = new System.Drawing.Point({cont.Location.X+cont.Padding.Left},{cont.Location.Y+cont.Padding.Top});";
                txtbxDesigner.Text += "\n            ";
                txtbxDesigner.Text += $"this.{control.Name}.Name = \"{control.Name}\";";
                txtbxDesigner.Text += "\n            ";
                txtbxDesigner.Text += $"this.{control.Name}.Size = new System.Drawing.Size({cont.Size.Width-(cont.Padding.Left*2)},{cont.Size.Height-(cont.Padding.Top*2)});";
                txtbxDesigner.Text += "\n            ";
                txtbxDesigner.Text += $"this.{control.Name}.Text = \"{control.Text}\";";
                txtbxDesigner.Text += "\n            ";
                txtbxDesigner.Text += $"this.{control.Name}.Enabled = {control.Enabled.ToString().ToLower()};";
                txtbxDesigner.Text += "\n            ";
                txtbxDesigner.Text += $"this.{control.Name}.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)({control.BackColor.R})))), ((int)(((byte)({control.BackColor.G})))), ((int)(((byte)({control.BackColor.B})))));";
                txtbxDesigner.Text += "\n            ";
                txtbxDesigner.Text += $"this.{control.Name}.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)({control.ForeColor.R})))), ((int)(((byte)({control.ForeColor.G})))), ((int)(((byte)({control.ForeColor.B})))));";
                txtbxDesigner.Text += "\n            ";
                switch (cont.ControlType)
                {
                    case fakeControlType.Empty:
                        break;
                    case fakeControlType.Label:
                        break;
                    case fakeControlType.Button:
                        break;
                    case fakeControlType.Checkbox:
                        break;
                    case fakeControlType.Textbox:
                        txtbxDesigner.Text += $"this.{control.Name}.Multiline = {(control as TextBox).Multiline.ToString().ToLower()};";
                        txtbxDesigner.Text += "\n            ";
                        break;
                    default:
                        break;
                }
                //events
                //char[] delimiters = { '$', '%', 'e', 'n','d','%', '$' };
                string str = control.Tag != null ? control.Tag.ToString() : "";
                var Events = str.Split('?');
                foreach (var Event in Events)
                {

                    if (String.IsNullOrEmpty(Event))
                        break;
                    //delimiters = new char[] { '$', '%', 's', 'p', 'l','i','t','%', '$' };

                    string eventName = Event.Split('$')[0];
                    string eventFunction = Event.Split('$')[1];

                    txtbxDesigner.Text += $"this.{control.Name}.{eventName} += new System.EventHandler(this.{eventFunction});";
                    txtbxDesigner.Text += "\n            ";
                }
            }
           txtbxDesigner.Text += @"

            //add controls
            ";
            foreach (ResizableControl cont in reForm.controls)
            {
                Control control = cont.getControl();
                txtbxDesigner.Text += $"this.Controls.Add({control.Name});";
                txtbxDesigner.Text += "\n            ";
            }
            txtbxDesigner.Text += @"
            this.Text = ""$%ProjectName%$"";
            "
            +
            $"this.Size = new System.Drawing.Size({reForm.Size.Width /*- (reForm.Padding.Left * 2)*/},{reForm.Size.Height + (reForm.Padding.Top*2)});"
            +
            @"
            //resume Layouts
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        ";
            foreach (ResizableControl cont in reForm.controls)
            {
                Control control = cont.getControl();
                txtbxDesigner.Text += $"private {control.GetType().FullName} {control.Name};";
                txtbxDesigner.Text += "\n        ";
            }
            txtbxDesigner.Text += @"
    }
}
";
        }

        private void tabctrlPages_Click(object sender, EventArgs e)
        {
            UpdateDesigner();
        }

        //private void label2_Click(object sender, EventArgs e)
        //{


        //    //Label label = new Label();
        //    //label.Text = "funny";
        //    //label.Name = "Label1";


        //    //label.Location = reForm.Location;
        //    //reForm.Controls.Add(label);
        //}

        private void lblLabel_Click(object sender, EventArgs e)
        {
            int labels = 0;
            foreach (ResizableControl control in reForm.controls)
            {
                if (control.getControl().GetType() == typeof(Label))
                    labels++;
            }
            ResizableControl label = new ResizableControl();
            label.ControlType = ResizableControl.fakeControlType.Label;
            label.Click += ClickControl;

            unSelectAllControls();
            reForm.addPanelControl(label);

            label.getPanel().Click += ClickControl;
            label.getControl().Click += ClickControl;

            label.changeControl("Name", "Label" + labels);
            label.changeControl("Text", "Label" + labels);
            label.changeControl("BackColor", Color.FromArgb(240, 240, 240));
            label.changeControl("Tag", "");
            reForm.SendToBack();
        }

        private void bttnButton_Click(object sender, EventArgs e)
        {
            int buttons = 0;
            foreach (ResizableControl control in reForm.controls)
            {
                if (control.getControl().GetType() == typeof(Button))
                    buttons++;
            }
            ResizableControl button = new ResizableControl();
            button.ControlType = ResizableControl.fakeControlType.Button;
            button.Click += ClickControl;

            unSelectAllControls();
            reForm.addPanelControl(button);

            button.getPanel().Click += ClickControl;
            button.getControl().Click += ClickControl;

            button.changeControl("Name", "Button" + buttons);
            button.changeControl("Text", "Button" + buttons);
            button.changeControl("BackColor", Color.FromArgb(220,220,220));
            button.changeControl("Tag", "");
            reForm.SendToBack();
        }
        private void chkbxCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int checkboxes = 0;
            foreach (ResizableControl control in reForm.controls)
            {
                if (control.getControl().GetType() == typeof(CheckBox))
                    checkboxes++;
            }
            ResizableControl checkbox = new ResizableControl();
            checkbox.ControlType = ResizableControl.fakeControlType.Checkbox;
            checkbox.Click += ClickControl;

            unSelectAllControls();
            reForm.addPanelControl(checkbox);

            checkbox.getPanel().Click += ClickControl;
            checkbox.getControl().Click += ClickControl;

            checkbox.changeControl("Name", "checkBox" + checkboxes);
            checkbox.changeControl("Text", "checkBox" + checkboxes);
            checkbox.changeControl("Tag", "");
            reForm.SendToBack();
        }

        private void txtbxTextbox_Click(object sender, EventArgs e)
        {
            int textboxes = 0;
            foreach (ResizableControl control in reForm.controls)
            {
                if (control.getControl().GetType() == typeof(TextBox))
                    textboxes++;
            }
            ResizableControl textbox = new ResizableControl();
            textbox.ControlType = ResizableControl.fakeControlType.Textbox;
            textbox.Click += ClickControl;

            unSelectAllControls();
            reForm.addPanelControl(textbox);

            textbox.getPanel().Click += ClickControl;
            textbox.getControl().Click += ClickControl;

            textbox.changeControl("Name", "textBox" + textboxes);
            textbox.changeControl("Text", "");
            textbox.changeControl("Tag", "");
            reForm.SendToBack();
        }

        private void reForm_SizeChanged(object sender, EventArgs e)
        {
            panTop.Width = reForm.Width-(reForm.Margin.Left*4);

            int y = reForm.Location.Y - panTop.Height+(reForm.Margin.Top*2);
            int x = reForm.Location.X + (reForm.Margin.Left*2);

            panTop.Location = new Point(x,y);
        }

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {
            lblVisibleTitle.Text = txtbxName.Text;
        }

        private void unSelectAllControls()
        {
            reForm.FakeEnabled = false;
            reForm.reDraw();

            foreach (ResizableControl control in reForm.controls)
            {
                control.FakeEnabled = false;
                control.reDraw();
            }
            ClickedControl = null;

        }

        private void tabFormDesign_Click(object sender, EventArgs e)
        {
            unSelectAllControls();
        }


        public void ClickControl(object sender, EventArgs e) 
        {
            ResizableControl control = (sender as ResizableControl);
            if (control == null)
                control = ((sender as Control).Parent as ResizableControl);
            if (control == null)
                control = ((sender as Control).Parent.Parent as ResizableControl);
            //if control is fake disabled
            if (control.FakeEnabled)
            {
                controlProps props = control.getControlProps();

                ClickedControl = control;

                if (props != null)
                    dataProperties.DataSource = props.ToTable(control.ControlType);

            }
        }


        public class controlProps
        {
            public string Name { get; set; }
            public string Text { get; set; }
            public bool Enabled { get; set; }
            public Color BackColor { get; set; }
            public Color ForeColor { get; set; }
            public Size Size { get; set; }
            public Point Location { get; set; }

            //Textbox
            public bool Multiline { get; set; }

            //CheckBox
            public bool Checked { get; set; }



        }

        private void dataProperties_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dataProperties.DataSource;
            controlProps props = dt.ToClass();
            ClickedControl.setControlProps(props,ClickedControl.ControlType);
        }

        private void bttnAddClick_Click(object sender, EventArgs e)
        {
            if (ClickedControl == null)
                return;
            addEvent("Click");


        }
        private void addEvent(string Event) 
        {
            string tag = ClickedControl.getControlPropertyValue("Tag");
            var Events = tag.Split('?');

            foreach (var evnt in Events)
            {
                if (String.IsNullOrEmpty(evnt)) 
                    break;

                string eventFunction = evnt.Split('$')[1];
                if (tag.Contains(eventFunction)) 
                {
                    tabctrlPages.SelectedTab = tabForm;
                    return;
                }
            }

            foreach (var line in txtbxUserCode.Lines)
            {
                if (line.Contains("//$%FunctionInsert%$"))
                {
                    int index = txtbxUserCode.Text.IndexOf("//$%FunctionInsert%$");
                    int startIndex = txtbxUserCode.Text.LastIndexOf('\n', index) + 1;
                    string indentation = txtbxUserCode.Text.Substring(startIndex, index - startIndex);

                    string newFunction =
                  @"
" + indentation + @"private void " + ClickedControl.getControl().Name + "_" + Event + @"(object sender, EventArgs e)
" + indentation + @"{
" + indentation + @"    MessageBox.Show(""Hello world"");
" + indentation + @"}
" + indentation + @"//$%FunctionInsert%$";

                    //int index = txtbxUserCode.Text.IndexOf(line);
                    //txtbxUserCode.Text = txtbxUserCode.Text.Remove(index, line.Length).Insert(index, newFunction);
                txtbxUserCode.Text = txtbxUserCode.Text.Remove(index, "//$%FunctionInsert%$".Length).Insert(index, newFunction);
                    break;

                }
        }

            ClickedControl.changeControl("Tag", tag + Event + "$" + ClickedControl.getControl().Name + "_" + Event + "?");
            tabctrlPages.SelectedTab = tabForm;
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (ClickedControl != null)
            {
                if (ClickedControl != reForm)
                {
                    reForm.DeleteControl(ClickedControl);
                    ClickedControl = null;
                }
            }
        }
    }
    public static class Helper
    {
        public static DataTable ToTable(this controlProps props, fakeControlType type)
        {
            //create a datatable to hold it all
            DataTable dt = new DataTable();

            //Add columns to the DataTable
            dt.Columns.Add("Property");
            dt.Columns.Add("Value");

            //Get the properties of the class using reflection
            PropertyInfo[] properties = props.GetType().GetProperties();

            //Add the properties and values as rows to the DataTable
            foreach (PropertyInfo property in properties)
            {

                switch (type)
                {
                    case fakeControlType.Button:
                        {
                            if (property.Name == "Checked") continue;
                            if (property.Name == "Multiline") continue;
                            break;
                        }
                    case fakeControlType.Label:
                        {
                            if (property.Name == "Checked") continue;
                            if (property.Name == "Multiline") continue;
                            break;
                        }
                    case fakeControlType.Checkbox:
                        {
                            if (property.Name == "Multiline") continue;
                            break;
                        }
                    case fakeControlType.Textbox:
                        {
                            if (property.Name == "Checked") continue;
                            break;
                        }
                    case fakeControlType.Empty:
                        {
                            if (property.Name == "Multiline") continue;
                            if (property.Name == "Checked") continue;
                            break;
                        }
                }


                DataRow row = dt.NewRow();
                row["Property"] = property.Name;
                if (property.Name == "BackColor" || property.Name == "ForeColor")
                {
                    Color color = (Color)property.GetValue(props);
                    int argb = color.ToArgb();
                    int red = (argb >> 16) & 0xFF;
                    int green = (argb >> 8) & 0xFF;
                    int blue = argb & 0xFF;
                    string rgb = "(" + red + ", " + green + ", " + blue + ")";
                    row["Value"] = rgb;

                }
                else if (property.Name == "Size") 
                {
                    Size newSize = (Size)property.GetValue(props);

                    row["Value"] = $"{newSize.Width},{newSize.Height}";
                }
                else if (property.Name == "Location")
                {
                    Point newLoc = (Point)property.GetValue(props);

                    row["Value"] = $"{newLoc.X},{newLoc.Y}";
                }
                else
                    row["Value"] = property.GetValue(props);
                dt.Rows.Add(row);
            }

            return dt;
        }
        public static controlProps ToClass(this DataTable dt)
        {
            controlProps props = new controlProps();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string propertyName = dt.Rows[i]["Property"].ToString();
                object value = dt.Rows[i]["Value"];

                PropertyInfo property = props.GetType().GetProperty(propertyName);
                if (property != null)
                {
                    if (propertyName == "BackColor" || propertyName == "ForeColor")
                    {
                        string colorString = value.ToString();
                        string[] parts = colorString.Split(',');
                        int red = int.Parse(parts[0].Replace("(",""));
                        int green = int.Parse(parts[1]);
                        int blue = int.Parse(parts[2].Replace(")", ""));
                        Color color = Color.FromArgb(red, green, blue);
                        property.SetValue(props,color);
                        //value = color;
                    }
                    else if (propertyName == "Size")
                    {
                        var values = value.ToString().Split(',');
                        int width = int.Parse(values[0]);
                        int height = int.Parse(values[1]);
                        var newSize = new Size(width, height);
                        property.SetValue(props, newSize);
                    }
                    else if (propertyName == "Location")
                    {
                        var values = value.ToString().Split(',');
                        int x = int.Parse(values[0]);
                        int y = int.Parse(values[1]);
                        var newLoc = new Point(x, y);
                        property.SetValue(props, newLoc);
                    }
                    else
                    {
                        try
                        {
                            var targetType = property.PropertyType;
                            value = Convert.ChangeType(value, targetType);
                        }
                        catch { }
                        property.SetValue(props, value);
                    }
                }
            }
            return props;
        }



        public static Color ToColor(this string input)
        {
            ColorConverter conv = new ColorConverter();
            return (Color)conv.ConvertFromString(input);
        }
    }
}
