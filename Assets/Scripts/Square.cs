using UnityEngine;

/// <summary>
/// A Square is a type of Shape.
/// Demonstrates Inheritance (from Shape) and Polymorphism (override DisplayText()).
/// </summary>
public class Square : Shape
{
    // Example unique field for a Square
    private int numberOfEdges = 4;

    public int NumberOfEdges
    {
        get { return numberOfEdges; }
        // Typically we wouldn't let this be changed, but it's here for demonstration
        set
        {
            if (value == 4)
            {
                numberOfEdges = value;
            }
            else
            {
                Debug.LogWarning("A square must have 4 edges!");
            }
        }
    }

    public override void DisplayText()
    {
        Debug.Log($"This is a Square named {ShapeName}, with {numberOfEdges} edges, size {Size}, color {ShapeColor}.");
    }
}