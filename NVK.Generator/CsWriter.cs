namespace NVK.Generator;

/// <summary>Helps writing C# files.</summary>
public class CsWriter
{
    /*********
    ** Fields
    *********/
    /// <summary>The <see cref="System.IO.StreamWriter"/> to write to.</summary>
    private StreamWriter StreamWriter;

    /// <summary>The number of 'tabs' to apply before writing the next line.</summary>
    private int IndentationLevel;


    /*********
    ** Public Methods
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="streamWriter">The <see cref="System.IO.StreamWriter"/> to write to.</param>
    public CsWriter(StreamWriter streamWriter)
    {
        StreamWriter = streamWriter;
    }

    /// <summary>Writes the header to the stream.</summary>
    public void WriteHeader() => StreamWriter.WriteLine("// this file was generated, don't edit manually");

    /// <summary>Writes a using directive to the stream.</summary>
    /// <param name="namespace">The namespace to write in the using directive.</param>
    public void WriteUsing(string @namespace) => StreamWriter.WriteLine($"using {@namespace};");

    /// <summary>Writes the indentation to the stream.</summary>
    public void WriteIdentation()
    {
        for (int i = 0; i < IndentationLevel; i++)
            Write('\t');
    }

    /// <summary>Writes a character to the stream.</summary>
    /// <param name="value">The character to write to the stream.</param>
    public void Write(char value) => StreamWriter.Write(value);

    /// <summary>Writes a string to the stream.</summary>
    /// <param name="value">The string to write to the stream.</param>
    public void Write(string value) => StreamWriter.Write(value);

    /// <summary>Writes a line terminator to the stream.</summary>
    public void WriteLine() => StreamWriter.WriteLine();

    /// <summary>Writes a character to the stream, followed by a line terminator.</summary>
    /// <param name="value">The character to write to the stream.</param>
    public void WriteLine(char value)
    {
        WriteIdentation();
        StreamWriter.WriteLine(value);
    }

    /// <summary>Writes a string to the stream, followed by a line terminator.</summary>
    /// <param name="value">The string to write to the stream.</param>
    public void WriteLine(string value)
    {
        WriteIdentation();
        StreamWriter.WriteLine(value);
    }

    /// <summary>Executes an <see cref="Action"/> inside a new scope.</summary>
    /// <param name="scopeInternal">The action to execute inside the scope.</param>
    public void WriteScope(Action scopeInternal)
    {
        WriteLine('{');
        IndentationLevel++;

        scopeInternal.Invoke();

        IndentationLevel--;
        WriteLine('}');
    }
}
