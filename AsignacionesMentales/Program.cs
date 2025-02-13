//Código Sucio

if (!(user.IsActive && user.HasPermission))
{
    Console.WriteLine("Access Denied");
}


//Código Limpio
bool hasAccess = user.IsActive && user.HasPermission;

if (!hasAccess)
{
    Console.WriteLine("Access Denied");
}
