using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using System.IO;
using UnityEngine.SceneManagement;
public class DialogueVariables
{
    private Dictionary<string, Ink.Runtime.Object> variables;


    public DialogueVariables(string globalFilePath, TextAsset yardTransitionInkJSON)
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
        Debug.Log("var updated");

        if (variables.ContainsKey(name))
        {
            variables.Remove(name);
            variables.Add(name, value);
        }
        
        if (name == "hint1" || name == "hint2" || name == "hint3" || name == "hint4" || name == "hint5")
        {
            TimeManager.GetInstance().AddPenalty(120);
        }


        CheckTimings();
    }

    public void VariablesToStory(Story story)
    {
        foreach (KeyValuePair<string, Ink.Runtime.Object> variable in variables)
        {
            story.variablesState.SetGlobal(variable.Key, variable.Value);
        }
    }

    private void CheckTimings()
    {
        //// example 
        if (!(DialogueManager.GetInstance().currentStory == null))
        {
            //bool shrimpQuest = (bool)DialogueManager.GetInstance().currentStory.variablesState.GetVariableWithName("shrimpQuest");
            //bool shrimpSolved = (bool)DialogueManager.GetInstance().currentStory.variablesState.GetVariableWithName("shrimpSolved");
            //bool beaten = (bool)DialogueManager.GetInstance().currentStory.variablesState.GetVariableWithName("beaten");
            //bool hasShrimp = (bool)DialogueManager.GetInstance().currentStory.variablesState.GetVariableWithName("hasShrimp");
            //bool officeOpen = (bool)DialogueManager.GetInstance().currentStory.variablesState.GetVariableWithName("officeOpen");

            //if (shrimpQuest == true)
            //{
            //    // indicate that a certain timing is done for coding later
            //    Debug.Log("shrimpQuest timing");
            //    // increment to next objective
            //    Objectives.GetInstance().SetObjective(0);
            //    // increment hint 
            //    HintManager.GetInstance().setPuzzleHint(0);
            //}

            //if (shrimpSolved == true)
            //{
            //    // indicate that a certain timing is done for coding later
            //    Debug.Log("shrimpSolved timing");
            //    // increment to next objective
            //    Objectives.GetInstance().SetObjective(1);
            //    // increment hint 
            //    HintManager.GetInstance().setPuzzleHint(1);
            //}

            //if (beaten == true)
            //{
            //    // indicate that a certain timing is done for coding later
            //    Debug.Log("beaten timing");
            //    // increment to next objective
            //    Objectives.GetInstance().SetObjective(2);
            //    // increment hint 
            //    HintManager.GetInstance().setPuzzleHint(2);
            //}

            //if (hasShrimp == true)
            //{
            //    // indicate that a certain timing is done for coding later
            //    Debug.Log("hasShrimp timing");
            //    // increment to next objective
            //    Objectives.GetInstance().SetObjective(3);
            //    // increment hint 
            //    HintManager.GetInstance().setPuzzleHint(3);
            //}

            //if (shrimpQuest == true)
            //{
            //    // indicate that a certain timing is done for coding later
            //    Debug.Log("officeOpen timing");
            //    // increment to next objective
            //    Objectives.GetInstance().SetObjective(4);
            //    // increment hint 
            //    HintManager.GetInstance().setPuzzleHint(4);
            //}



           



        }


    }
}

