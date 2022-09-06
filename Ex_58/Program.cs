int m = 2;
int n = 2;
int[,] arr = new int[m,n];
Random rand = new Random(DateTime.Now.Millisecond);
for (int i = 0; i < m; i++) {
for (int j = 0; j < n; j++) {
arr[i, j] = rand.Next(0, 20);
}
}
int[,] b = new int[m,n];
for (int i = 0; i < m; i++) {
for (int j = 0; j < n; j++) {
b[i, j] = rand.Next(0, 20);
}
}


string otv = "";
for (int i = 0; i < m; i++) {
otv = "";
for (int j = 0; j < n; j++){
otv += arr[i, j];
if (j<n-1) {
otv += " ";
}
}
Console.WriteLine(otv);
}
for (int i = 0; i < m; i++) {
otv = "";
for (int j = 0; j < n; j++){
otv += b[i, j];
if (j<n-1) {
otv += " ";
}
}
Console.WriteLine(otv);
}


int[,] c = new int[m,n];

for (int i = 0; i < m; i++){
for (int j = 0; j < n; j++)
{
c[i,j] = 0;
for (int k = 0; k < m; k++){
c[i,j] += arr[i,k] * b[k,j];
}
}
}


Console.WriteLine("otvet:");
string otvet = "";

for (int i = 0; i < m; i++) {
otvet = "";
for (int j = 0; j < n; j++){
otvet += c[i, j];
if (j<n-1) {
otvet += " ";
}
}
Console.WriteLine(otvet);
}
