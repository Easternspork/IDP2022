using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using System.IO;

public class DialogueVariables
{
    private Dictionary<string, Ink.Runtime.Object> variables;

    public DialogueVariables(string globalFilePath)
    {
        string inkFileContents = File.ReadAllText(globalFilePath);
        Ink.Compiler compiler = new Ink.Compiler(inkFileContents);
        Story globalVariablesStory = compiler.Compile();

        variables = new Dictionary<string, Ink.Runtime.Object>();
        foreach (string name in globalVariablesStory.variablesState)
        {
            Ink.Runtime.Object value = globalVariablesStory.variablesState.GetVariableWithName(name);
            variables.Add(name, value);
        }
    }

    public void StartListening(Story story)
    {
        VariablesToStory(story);
        story.variablesState.variableChangedEvent += VariableChanged;
    }

    public void StopListening(Story story)
    {
        story.variablesState.variableChangedEvent -= VariableChanged;
    }

    private void VariableChanged(string name, Ink.Runtime.Object value)
    {
        if (variables.ContainsKey(name))
        {
            variables.Remove(name);
            variables.Add(name, value);
        }
        
        if (name == "hint1" || name == "hint2" || name == "hint3" || name == "hint4" || name == "hint5")
        {
            TimeManager.GetInstance().AddPenalty(60);
        }


        CheckTimings();
    }

    private void VariablesToStory(Story story)
    {
        foreach (KeyValuePair<string, Ink.Runtime.Object> variable in variables)
        {
            story.variablesState.SetGlobal(variable.Key, variable.Value);
        }
    }

    private void CheckTimings()
    {
        // example 

        bool morning = (bool)DialogueManager.GetInstance().currentStory.variablesState.GetVariableWithName("hint1");

        if (morning == true)
        {
            // indicate that a certain timing is done for coding later
            Debug.Log("morning timing");
            // increment to next objective
            Objectives.GetInstance().NextObjective();
            // increment hint 
            HintManager.GetInstance().NextPuzzleHint();
        }
    }
}

