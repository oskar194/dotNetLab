﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zabawki
{
    public partial class Form1 : Form
    {


        Dictionary<int, Object> objDic = new Dictionary<int, object>();
        int id = 0;
        Object selected = null;
        enum Types { Car, Computer, Plane, Submarine };

        public Form1()
        {
            InitializeComponent();
            riseButton.Enabled = false;
            accButton.Enabled = false;
            diveButton.Enabled = false;
            typeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            typeComboAdd.DropDownStyle = ComboBoxStyle.DropDownList;
            nameCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var type in Enum.GetValues(typeof(Types)))
            {
                typeCombo.Items.Add(new Item(type.ToString(), (int)type));
                typeComboAdd.Items.Add(new Item(type.ToString(), (int)type));
            }
            typeCombo.Items.Add(new Item("", -1));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ((IDive)selected).Dive((int)numericUpDown1.Value);
            DescribeSelectedObject();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ((IRise)selected).Rise((int)numericUpDown1.Value);
            DescribeSelectedObject();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ((IAccelerate)selected).Accelerate((int)numericUpDown1.Value);
            DescribeSelectedObject();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(typeCombo.Text !=null)
            {
                selected = objDic[(nameCombo.SelectedItem as Item).Value];
            }
            if(selected != null)
            {
                DescribeSelectedObject();

            }
        }

        private void DescribeSelectedObject()
        {
            StringBuilder sb = new StringBuilder();
            int t = ExamineType(selected);
            sb.Append("Type: " + ((Types)t).ToString() + "\n");
            sb.Append(getObjInfoAndBlockButtons(selected));
            selectedDesc.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!typeComboAdd.Text.Equals(""))
            {
                string text = typeComboAdd.Text;
                objDic.Add(id, GetInstance(text));
                text = text + id;
                nameCombo.Items.Add(new Item(text, id));
                id++;
            }

        }

        void populateNameCombo()
        {
            for(int i=0; i==id; i++)
            {
                string name = ((Types)ExamineType(objDic[i])).ToString();
                name = name + i;
                if (!nameCombo.Items.Contains(new Item(name, i))){
                    nameCombo.Items.Add(new Item(name, id));
                }
            }
        }

        string getObjInfoAndBlockButtons(Object obj)
        {
            string desc = "";
            diveButton.Enabled = false;
            riseButton.Enabled = false;
            accButton.Enabled = false;
            if (obj is IDive)
            {
                diveButton.Enabled = true;
                desc += "Depth: " + ((IDive)obj).GetDive().ToString() + "\n";
            }
            if (obj is IRise)
            {
                riseButton.Enabled = true;
                desc += "Level: " + ((IRise)obj).GetRise().ToString() + "\n";
            }
            if (obj is IAccelerate)
            {
                accButton.Enabled = true;
                desc += "Acceleration: " + ((IAccelerate)obj).GetAcceleration().ToString() + "\n";
            }
            return desc;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private object GetInstance(string typeName)
        {
            string fullName = "Zabawki." + typeName;
            Type t = Type.GetType(fullName);
            return Activator.CreateInstance(t);
        }

        private int ExamineType(Object obj)
        {
            if(obj is IDive)
            {
                return (int)Types.Submarine;
            }else if(obj is IRise)
            {
                return (int)Types.Plane;
            }else if(obj is IAccelerate)
            {
                return (int)Types.Car;
            }
            else
            {
                return (int)Types.Computer;
            }
        }

        private void nameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeCombo.SelectedIndex = ExamineType(objDic[(nameCombo.SelectedItem as Item).Value]);
        }

        private void typeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeCombo.SelectedText.Equals(""))
            {
                populateNameCombo();
            }
            else
            {
                nameCombo.Items.Clear();
                foreach (Item it in nameCombo.Items)
                {
                    if (ExamineType(objDic[it.Value]) == (typeCombo.SelectedItem as Item).Value)
                    {
                        nameCombo.Items.Add(it);
                    }
                }
            }
            
    
        }

        private void selectedDesc_Click(object sender, EventArgs e)
        {

        }
    }
}
