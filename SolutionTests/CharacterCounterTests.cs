using System;
using Solution;
using System.Collections.Generic;
using Xunit;

public class CharacterCounterTests 
{
	public CharacterCounter subject { get; set; }

	public CharacterCounterTests()
	{
		this.subject = new CharacterCounter();
	}
	[Fact]
    public void FinalTest1() {
		Dictionary<char, int> d = new Dictionary<char, int>();
    	d.Add('a', 4);
    	Assert.Equal(d, subject.Count("aaaa"));
    }

	[Fact]
	public void FinalTest2()
	{
		Dictionary<char, int> d = new Dictionary<char, int>();
		d.Add('a', 2);
    	d.Add('b', 2);
    	Assert.Equal(d, subject.Count("aabb"));
	}
}  