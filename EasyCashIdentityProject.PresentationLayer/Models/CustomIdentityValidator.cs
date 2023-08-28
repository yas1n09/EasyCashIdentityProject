using Microsoft.AspNetCore.Identity;

namespace EasyCashIdentityProject.PresentationLayer.Models
{
	public class CustomIdentityValidator:IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Parola en az {length} larakter olmalıdır."
			};
		}
		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = $"Parola En Az 1 Büyük Harf İçermeli."
		};
		}

		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = $"Parola En Az 1 Küçük Harf İçermeli."
			};
		}

		public override IdentityError PasswordRequiresDigit()		
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresDigit",
				Description = $"Parola En Az 1 Sayı  İçermeli."
			};
		}
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = $"Parola En Az 1  Sembol İçermeli."
			};
		}

	}
}
