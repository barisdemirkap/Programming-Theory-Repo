using UnityEngine;

/// <summary>
/// Base class demonstrating Inheritance, Encapsulation (private fields + public properties),
/// and Abstraction (common methods). We'll make this an abstract class so each child
/// must implement its own version of DisplayText().
/// </summary>
public abstract class Shape : MonoBehaviour
{
    // Encapsulated data
    [SerializeField] private string shapeName;
    [SerializeField] private Color shapeColor = Color.white;
    [SerializeField] private float size = 1f;

    // Properties with basic validation as an example
    public string ShapeName
    {
        get { return shapeName; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                shapeName = value;
            }
            else
            {
                Debug.LogWarning("ShapeName cannot be empty. Keeping the old name.");
            }
        }
    }

    public Color ShapeColor
    {
        get { return shapeColor; }
        set
        {
            // Just an example — you could add checks for brightness, etc.
            shapeColor = value;
            ApplyColor(); // Whenever the color changes, apply it to the Renderer
        }
    }

    public float Size
    {
        get { return size; }
        set
        {
            if (value > 0f)
            {
                size = value;
                ApplySize(); // Adjust the transform scale
            }
            else
            {
                Debug.LogWarning("Size must be > 0. Keeping the old size.");
            }
        }
    }

    // Unity method called on object creation or scene start
    protected virtual void Start()
    {
        // Apply the current color and size
        ApplyColor();
        ApplySize();
    }

    /// <summary>
    /// Apply the shape's color to the Renderer component.
    /// This is an example of an abstraction: all shapes share this logic.
    /// </summary>
    protected void ApplyColor()
    {
        // Ensure we have a Renderer
        Renderer rend = GetComponent<Renderer>();
        if (rend != null)
        {
            rend.material.color = shapeColor;
        }
    }

    /// <summary>
    /// Apply the shape's size to the transform scale.
    /// This is also an example of shared logic in the base class.
    /// </summary>
    protected void ApplySize()
    {
        // Uniform scale based on "size"
        transform.localScale = Vector3.one * size;
    }

    /// <summary>
    /// Abstract method each child must implement. 
    /// Demonstrates polymorphism when overridden by each child class.
    /// </summary>
    public abstract void DisplayText();

    /// <summary>
    /// Unity method invoked when the user has pressed the mouse button while 
    /// over the Collider of this GameObject.
    /// </summary>
    private void OnMouseDown()
    {
        // When clicked, each shape will use its own DisplayText() implementation.
        DisplayText();
    }
}
