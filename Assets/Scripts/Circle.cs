using UnityEngine;

/// <summary>
/// A Circle is a specific type of Shape.
/// Demonstrates Inheritance (from Shape) and Polymorphism (override DisplayText()).
/// </summary>
public class Circle : Shape
{
    // Example of a unique field or property just for Circle
    private float radius;

    public float Radius
    {
        get { return radius; }
        set 
        {
            if (value > 0f)
            {
                radius = value;
            }
            else
            {
                Debug.LogWarning("Radius must be positive.");
            }
        }
    }

    // Polymorphic behavior: Different shapes will display different text
    public override void DisplayText()
    {
        Debug.Log($"This is a Circle named {ShapeName}, colored {ShapeColor}, with a size of {Size}.");
    }
}