using System.Collections;

/// <summary>
/// [TODO:description]
/// </summary>
public enum TestEnum
{
    One,
    Two,
    Three
}

/// <summary>
/// [TODO:description]
/// </summary>
public class TestCS
{
    /// <summary>
    /// [TODO:description]
    /// </summary>
    public const double PI = 3.14;


    /// <summary>
    /// [TODO:description]
    /// </summary>
    public int one = 1;

    /// <summary>
    /// [TODO:description]
    /// </summary>
    public int Prop { 
        get 
        { 
            return 1; 
        } 
        set 
        { 
        } 
    }

    public static string operator +()
    {
    }

    public delegate string Del(string arg1, int dontForgetMe);

    /// <summary>
    /// [TODO:description]
    /// </summary>
    public event Del EventHappened;

    /// <summary>
    /// [TODO:description]
    /// </summary>
    /// <param name="number">[TODO:description]</param>
    /// <summary>
    /// [TODO:description]
    /// </summary>
    public delegate void Del();

    /// <summary>
    /// [TODO:description]
    /// </summary>
    /// <param name="first">[TODO:description]</param>
    /// <param name="second">[TODO:description]</param>
    /// <summary>
    /// [TODO:description]
    /// </summary>
    public static string operator +() 
    { 
        return first; 
    }

    /// <summary>
    /// [TODO:description]
    /// </summary>
    public TestCS()
    {
    }

    /// <summary>
    /// [TODO:description]
    /// </summary>
    /// <param name="arg1">[TODO:description]</param>
    public TestCS(string arg1)
    {
    }

    /// <summary>
    /// [TODO:description]
    /// </summary>
    /// <param name="arg1">[TODO:description]</param>
    /// <param name="arg2">[TODO:description]</param>
    public TestCS(string arg1, List<string> arg2)
    {
    }

    /// <summary>
    /// [TODO:description]
    /// </summary>
    public void ActualMethod1()
    {
    }

    /// <summary>
    /// [TODO:description]
    /// </summary>
    /// <retrurns>[TODO:description]</returns>
    public string ActualMethodWitReturn()
    {
        return "";
    }

    /// <summary>
    /// [TODO:description]
    /// </summary>
    /// <param name="arg1">[TODO:description]</param>
    /// <param name="arg2">[TODO:description]</param>
    public void ActualMethodWitArgs(?List<string> arg1, int arg2)
    {
    }

    /// <summary>
    /// [TODO:description]
    /// </summary>
    /// <param name="arg1">[TODO:description]</param>
    /// <param name="arg2">[TODO:description]</param>
    /// <retrurns>[TODO:description]</returns>
    public string ActualMethodWitArgsAndReturn(?List<string> arg1, int arg2)
    {
        return  "";
    }


    /// <summary>
    /// [TODO:description]
    /// </summary>
    public class NestedClass 
    { 
    }
}