// ============================================
// Program #196 — CommandPattern
// Category  : 20_Design_Patterns
// Difficulty: Intermediate
// Description: Executes and undoes text editor commands
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.DesignPatterns
{
    interface ITextCommand
    {
        void Execute();
        void Undo();
    }

    class TextEditor
    {
        public string Content { get; private set; } = string.Empty;

        public void Append(string text) => Content += text;
        public void RemoveLast(int count)
        {
            if (count <= 0) return;
            int start = Math.Max(Content.Length - count, 0);
            Content = Content.Substring(0, start);
        }
    }

    class WriteCommand : ITextCommand
    {
        private readonly TextEditor _editor;
        private readonly string _text;

        public WriteCommand(TextEditor editor, string text)
        {
            _editor = editor;
            _text = text;
        }

        public void Execute() => _editor.Append(_text);
        public void Undo() => _editor.RemoveLast(_text.Length);
    }

    class DeleteCommand : ITextCommand
    {
        private readonly TextEditor _editor;
        private readonly int _count;
        private string _deleted = string.Empty;

        public DeleteCommand(TextEditor editor, int count)
        {
            _editor = editor;
            _count = count;
        }

        public void Execute()
        {
            int start = Math.Max(_editor.Content.Length - _count, 0);
            _deleted = _editor.Content.Substring(start);
            _editor.RemoveLast(_count);
        }

        public void Undo() => _editor.Append(_deleted);
    }

    class Program_196_CommandPattern
    {
        static void Main(string[] args)
        {
            var editor = new TextEditor();
            var history = new Stack<ITextCommand>();

            void ExecuteCommand(ITextCommand command)
            {
                command.Execute();
                history.Push(command);
                Console.WriteLine($"Content: {editor.Content}");
            }

            ExecuteCommand(new WriteCommand(editor, "Hello "));
            ExecuteCommand(new WriteCommand(editor, "World"));
            ExecuteCommand(new DeleteCommand(editor, 5));

            var last = history.Pop();
            last.Undo();
            Console.WriteLine($"After undo: {editor.Content}");
        }
    }
}
