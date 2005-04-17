//
// This is a test for bug #57703
//
using System;
using System.Reflection;

public interface ITest {
	event EventHandler DocBuildingStep;
}

class X {
	static void Main ()
	{
		return typeof (ITest).GetFields (BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).Length;
	}
}
