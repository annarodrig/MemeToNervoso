string fraseUsuario, fraseMemeToNervoso;

Console.WriteLine("Usuário, o que você pensa sobre mim?");
fraseUsuario = Console.ReadLine()!;

// Remove os últimos caracteres da frase digitada pelo usuario e troca pelo meme
fraseMemeToNervoso = $"{fraseUsuario.Remove(10)}... NÃO, PERA.\nTô nervoso";

Console.WriteLine(fraseMemeToNervoso);

