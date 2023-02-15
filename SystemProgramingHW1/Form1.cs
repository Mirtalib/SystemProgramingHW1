using System;
using System.Diagnostics;

namespace SystemProgramingHW1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        foreach (var item in Process.GetProcesses())
            listBox1.Items.Add((item.Id + " " + item.ProcessName + " " + item.MachineName + " " + item.Threads.Count + " " + item.HandleCount));
    }
}