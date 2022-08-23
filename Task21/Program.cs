// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int [] A = {3, 6, 8};
int [] B = {2, 1, -7};

int Task21(int i)
{
    int Vector = (A[i]-B[i])*(A[i]-B[i]);
return Vector;
}

int distance = Task21(0)+Task21(1)+Task21(2);

Console.WriteLine(MathF.Sqrt(distance));
