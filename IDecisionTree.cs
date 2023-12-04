namespace Decision;

public interface IDecisionTree {
    void Fit(IEnumerable<(Dictionary<string, double>, string)> dataset);
    void Fit(IEnumerable<(string, double)> preOrderTraversal);
    string Predict(Dictionary<string, double> x);
    IEnumerable<(string,double)> PreOrderTraversal();
}

