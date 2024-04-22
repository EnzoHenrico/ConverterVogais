// Faça um vetor de caracteres com 10 posições e converta as vogais de minúsculo para maiúsculo.

char[] characters = new char[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"Caractere {i + 1}: ");
    characters[i] = char.Parse(Console.ReadLine());
    
    switch (characters[i])
    {
        case 'a':
            characters[i] = 'A';
            break;
        case 'e':
            characters[i] = 'E';
            break;
        case 'i':
            characters[i] = 'I';
            break;
        case 'o':
            characters[i] = 'O';
            break;
        case 'u':
            characters[i] = 'U';
            break;
    }
}

Console.WriteLine("\nVogais maiúsculas: \n");
for (int i = 0; i < 10; i++)
{
    Console.Write(characters[i]);
}