public static int FlippingMatrix(List<List<int>> matrix)
{
    var arrCount = matrix.Count;
    var n = arrCount/2;
    var sum = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            var max= (new List<int> { 
                matrix[i][j] ,// 
                matrix[i][arrCount-1-j],// Symmetry 1
                matrix[arrCount-1-j][j],// Symmetry 2
                matrix[arrCount-1-i][arrCount-1-j]// Symmetry 2
            
            }).Max();
            sum += max;
        }
    }

    return sum;
}