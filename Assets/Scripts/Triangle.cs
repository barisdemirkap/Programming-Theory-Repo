using UnityEngine;

/// <summary>
/// A Triangle is a type of Shape.
/// Demonstrates Inheritance (from Shape) and Polymorphism (override DisplayText()).
/// </summary>
public class Triangle : Shape
{
    // Example unique field for a Triangle
    private int numberOfCorners = 3;

    public int NumberOfCorners
    {
        get { return numberOfCorners; }
        // Typically we wouldn’t let this be changed, but for demonstration, we have a setter.
        set
        {
            if (value == 3)
            {
                numberOfCorners = value;
            }
            else
            {
                Debug.LogWarning("A triangle must have 3 corners!");
            }
        }
    }

    public override void DisplayText()
    {
        Debug.Log($"This is a Triangle named {ShapeName}, with {numberOfCorners} corners, size {Size}, color {ShapeColor}.");
    }
}