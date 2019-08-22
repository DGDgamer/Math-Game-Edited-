using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MathsOperation
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
    Exponent,
    Fraction
}

[System.Serializable]
public class Problem
{
    // problem: 5 + 10
    // answers: 20, 8, 15, 30
    // correct tube: 2 

    public string firstNumber;
    public string secondNumber;
    public MathsOperation operation;
    public string[] answers;

    public int correctTube;
}