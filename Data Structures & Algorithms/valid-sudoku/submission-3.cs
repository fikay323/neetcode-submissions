public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rowBuckets = new HashSet<char>[9];
        var colBuckets = new HashSet<char>[9];
        var boxBuckets = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            rowBuckets[i] = new HashSet<char>();
            colBuckets[i] = new HashSet<char>();
            boxBuckets[i] = new HashSet<char>();
        }

        for(int i = 0; i < 9; i++) {
            for(int j = 0; j < 9; j++){
                var val = board[i][j];
                if(val == '.') continue;

                var box = ((i / 3) * 3) + (j / 3);

                if(rowBuckets[i].Contains(val) ||
                    colBuckets[j].Contains(val) ||
                    boxBuckets[box].Contains(val)
                ) return false;

                rowBuckets[i].Add(val);
                colBuckets[j].Add(val);
                boxBuckets[box].Add(val);
            }
        }

        return true;
    }
}
