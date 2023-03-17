void writeSum(int start, int end) {
    int sum =  recursiveSum(start, end);
    Console.WriteLine(sum);
}

int recursiveSum(int start, int end) {
    if (start < end) {
        int sum = start + recursiveSum(start + 1, end);
        return sum;
    }
    else {
        return end;
    }
}
