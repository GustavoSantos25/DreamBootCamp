using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level
{
    public Input[] Inputs { get; set; }
    public Command[] Commands { get; set; }
    public string Question { get; set; }
    public int NumberOfInputSlots { get; set; }

    public override string ToString()
   {
        string String = "";
        String += "Question: " + Question + '\n';
        String += "Commands available:\n";
        foreach(Command command in Commands){
            String += command.ToString() + '\n';
        }
        String += "Inputs:\n";
        foreach(Input input in Inputs){
            String += input.ToString() + '\n';
        }
        String += "Number of Input Slots: " + NumberOfInputSlots + '\n';
        
        return String;
   }
}
