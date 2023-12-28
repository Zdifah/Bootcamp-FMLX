using System;
using System.Collections.Generic;
// Client
class Program
{
    static void Main()
    {
        // Membuat elemen tunggal
        IGUIElement button1 = new Button("OK");
        IGUIElement button2 = new Button("Cancel");
        IGUIElement textBox = new TextBox();

        // Membuat elemen komposit
        IGUIElement panel = new Panel();
        ((Panel)panel).AddElement(button1);
        ((Panel)panel).AddElement(button2);
        ((Panel)panel).AddElement(textBox);

        // Menampilkan rendering GUI
        panel.Render();
    }
}

// Komponen (Component)
interface IGUIElement
{
	void Render();
}

// Elemen Tunggal (Leaf)
class Button : IGUIElement
{
	private string label;

	public Button(string label)
	{
		this.label = label;
	}

	public void Render()
	{
		Console.WriteLine($"Render Button: {label}");
	}
}

// Elemen Tunggal (Leaf)
class TextBox : IGUIElement
{
	public void Render()
	{
		Console.WriteLine("Render TextBox");
	}
}

// Elemen Komposit (Composite)
class Panel : IGUIElement
{
	private List<IGUIElement> elements = new List<IGUIElement>();

	public void AddElement(IGUIElement element)
	{
		elements.Add(element);
	}

	public void Render()
	{
		Console.WriteLine("Render Panel");
		foreach (IGUIElement element in elements)
		{
			element.Render();
		}
	}
}


