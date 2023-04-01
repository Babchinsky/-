using System;
using System.Collections.Generic;
using System.Linq;

// Класс, который хранит текст и позволяет создавать объекты Memento
public class TextEditor
{
    private string _text;

    public string Text
    {
        get { return _text; }
        set { _text = value; }
    }

    public TextEditorMemento CreateMemento()
    {
        return new TextEditorMemento(_text);
    }

    public void RestoreMemento(TextEditorMemento memento)
    {
        _text = memento.Text;
    }
}

// Класс, который хранит состояние текста
public class TextEditorMemento
{
    public string Text { get; private set; }

    public TextEditorMemento(string text)
    {
        Text = text;
    }
}

// Класс, который управляет хранением объектов TextEditorMemento и предоставляет методы для выполнения операций Undo/Redo
public class TextEditorCareTaker
{
    private Stack<TextEditorMemento> _mementos = new Stack<TextEditorMemento>();
    private int _maxUndoSteps = 256;

    public void AddMemento(TextEditorMemento memento)
    {
        _mementos.Push(memento);
        EnsureMaxUndoSteps();
    }

    public TextEditorMemento Undo()
    {
        if (_mementos.Count > 1)
        {
            TextEditorMemento memento = _mementos.Pop();
            return _mementos.Peek();
        }
        return null;
    }

    public TextEditorMemento Redo()
    {
        if (_mementos.Count > 1)
        {
            return _mementos.Pop();
        }
        return null;
    }

    public int Count
    {
        get { return _mementos.Count; }
    }

    private void EnsureMaxUndoSteps()
    {
        if (_mementos.Count > _maxUndoSteps)
        {
            _mementos = new Stack<TextEditorMemento>(_mementos.Take(_maxUndoSteps));
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объекта CareTaker, который будет управлять хранением объектов Memento
        var careTaker = new TextEditorCareTaker();

        // Создание объекта Originator, который будет хранить текст
        var textEditor = new TextEditor();

        // Добавление начального состояния текста в стек Memento
        careTaker.AddMemento(textEditor.CreateMemento());

        while (true)
        {
            Console.WriteLine("Enter a command (Type 'help' for list of commands):");
            var command = Console.ReadLine().ToLower();

            switch (command)
            {
                case "help":
                    Console.WriteLine("Available commands:");
                    Console.WriteLine("  - edit <text>: Edit the text");
                    Console.WriteLine("  - undo: Undo the last edit");
                    Console.WriteLine("  - redo: Redo the last undo");
                    Console.WriteLine("  - exit: Exit the program");
                    break;

                case "edit":
                    Console.Write("Enter the new text: ");
                    var newText = Console.ReadLine();

                    // Изменение текста
                    textEditor.Text = newText;

                    // Добавление измененного состояния текста в стек Memento
                    careTaker.AddMemento(textEditor.CreateMemento());

                    // Вывод текущего текста
                    Console.WriteLine("Current Text: {0}", textEditor.Text);
                    break;

                case "undo":
                    if (careTaker.Count < 2)
                    {
                        Console.WriteLine("Nothing to undo.");
                    }
                    else
                    {
                        textEditor.RestoreMemento(careTaker.Undo());

                        // Вывод текста после операции Undo
                        Console.WriteLine("After Undo: {0}", textEditor.Text);
                    }
                    break;

                case "redo":
                    if (careTaker.Count < 2)
                    {
                        Console.WriteLine("Nothing to redo.");
                    }
                    else
                    {
                        textEditor.RestoreMemento(careTaker.Redo());

                        // Вывод текста после операции Redo
                        Console.WriteLine("After Redo: {0}", textEditor.Text);
                    }
                    break;

                case "exit":
                    return;

                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }

}
