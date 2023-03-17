int A(int m, int n) {
    if (m == 0) {
        int result = n + 1;
        return result;
    }
    if (n == 0) {
        return A(m - 1, 1);
    }
    return A(m - 1, A(m, n - 1));
}

void writeA(int m, int n) {
    int a = A(m, n);
    Console.WriteLine(a);
}

int getNumberFromUser() {
    Console.WriteLine("Write a natural number:");
    string input = Console.ReadLine();
    int number = int.Parse(input);
    return number;
}

int m = getNumberFromUser();
int n = getNumberFromUser();
writeA(m, n);
