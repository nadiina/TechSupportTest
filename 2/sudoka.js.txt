function isValidSudoku(board) {
    let rows = Array.from({ length: 9 }, () => Array(9).fill(0));
    let columns = Array.from({ length: 9 }, () => Array(9).fill(0));
    let boxes = Array.from({ length: 9 }, () => Array(9).fill(0));

    for (let i = 0; i < 9; i++) {
        for (let j = 0; j < 9; j++) {
            let current = board[i][j];
           
                let num = parseInt(current) - 1;
                let boxIndex = Math.floor(i / 3) * 3 + Math.floor(j / 3);

                rows[i][num]++;
                columns[j][num]++;
                boxes[boxIndex][num]++;

                if (rows[i][num] > 1 || columns[j][num] > 1 || boxes[boxIndex][num] > 1) {
                    return false;
                }
            
        }
    }
    return true;
}



let validBoard = [
    [5, 3, 4, 6, 7, 8, 9, 1, 2],
    [6, 7, 2, 1, 9, 5, 3, 4, 8],
    [1, 9, 8, 3, 4, 2, 5, 6, 7],
    [8, 5, 9, 7, 6, 1, 4, 2, 3],
    [4, 2, 6, 8, 5, 3, 7, 9, 1],
    [7, 1, 3, 9, 2, 4, 8, 5, 6],
    [9, 6, 1, 5, 3, 7, 2, 8, 4],
    [2, 8, 7, 4, 1, 9, 6, 3, 5],
    [3, 4, 5, 2, 8, 6, 1, 7, 9]
];

let invalidBoard = [
    [5, 3, 4, 6, 7, 8, 9, 1, 2],
    [6, 7, 2, 1, 9, 0, 3, 4, 8],
    [1, 0, 0, 3, 4, 2, 5, 6, 0],
    [8, 5, 9, 7, 6, 1, 0, 2, 0],
    [4, 2, 6, 8, 5, 3, 7, 9, 1],
    [7, 1, 3, 9, 2, 4, 8, 5, 6],
    [9, 0, 1, 5, 3, 7, 2, 1, 4],
    [2, 8, 7, 4, 1, 9, 6, 3, 5],
    [3, 0, 0, 4, 8, 1, 1, 7, 9]
];

console.log(isValidSudoku(validBoard));   
console.log(isValidSudoku(invalidBoard)); 