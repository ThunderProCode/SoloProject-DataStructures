using Decision;

public class DecisionTree : IDecisionTree
{
    public void Fit(IEnumerable<(Dictionary<string, double>, string)> dataset)
    {
        throw new NotImplementedException();
    }

    public void Fit(IEnumerable<(string, double)> preOrderTraversal)
    {
        throw new NotImplementedException();
    }

    public string Predict(Dictionary<string, double> x)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<(string, double)> PreOrderTraversal()
    {
        throw new NotImplementedException();
    }
}