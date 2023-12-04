namespace DataStructuresSoloProject;

public class Tests
{
    [Test]
    public void Test1()
    {
        DecisionTree t = new DecisionTree();
        t.Fit(new []{("a", double.NaN)});
        var label = t.Predict(new Dictionary<string, double>());
        Assert.That(label, Is.EqualTo("a"));
    }

    [Test]
    public void TestSingleNodeTreeWithDifferentLabel()
    {
        DecisionTree t = new DecisionTree();
        t.Fit(new []{("a", double.NaN)});
        var label = t.Predict(new Dictionary<string, double>());
        Assert.That(label, Is.EqualTo("a"));
    }

}