namespace SecurityOrgPrj.Data
{
	public class DbObjects
	{
		public static void initial(AppDBContent content) //Добавляє кожен раз нові об'єкти
		{
			content.SaveChanges();

		}
	}
}
