using System;
using System.Linq;

// Words Code 

public class Word

{
    // Variables
    public string _words = "";
    public string _ref = "";
    public string[] _result;
    public List<int> _hidden;

    // Methods
    public Word()

    {

    }

    public Word(string text, string visible)

    {

    }
    public void GetRenderedText(Scripture scripture)
    {
        var _words = scripture._scriptureText;
        _result = _words.Split(" ");
        _hidden = new List<int>();
    }
    public void GetRenderedRef(Scripture scripture)

    {

    }

    public void Show(string ref1)
    {
       _ref = ref1;
        Console.Clear();
        Console.Write("\n Spacebar hide words");
        Console.Write("\n Q to Exit \n");
        // Console.Write($"{_hidden.Count}, {_result.Length}\n");

        Console.WriteLine($"{_ref}");

        for (var i = 0; i < _result.Length; i++)

        {
            var str = _result[i];
            int len = str.Length;
            string dashedLine = new String('_', len);
            if (_hidden.Contains(i))
            {
                Console.Write($"{dashedLine} ");
            }
            else
            {
                Console.Write($"{str} ");
            }
        }

    }

    public void GetReadKey()

    {
        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Spacebar || input.Key == ConsoleKey.Enter)
        {
            GetNewHiddenWord();
            // GetNewHiddenWord();
        }
        else if (input.Key == ConsoleKey.Q)
        {
            Environment.Exit(0);
        }
    }
    public void GetNewHiddenWord()

    {
        // var cap hidden values

        // cap = _result.Length;

        var random = new Random();
        var index1 = random.Next(_result.Length);
        var index2 = random.Next(_result.Length);
        if (_hidden.Contains(index1) || _hidden.Contains(index2))

        {
            GetNewHiddenWord();
        }

        else
        {
            _hidden.Add(index1);
            _hidden.Add(index2);

        }
        
    }


}