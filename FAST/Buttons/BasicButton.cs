using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.Buttons
{
    public class BasicButton
    {
		private string title;
		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		private string description;
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		private string tabName;
		public string TabName
		{
			get { return tabName; }
			set { tabName = value; }
		}

		private string buttonType;
		public string ButtonType
		{
			get { return buttonType; }
			set { buttonType = value; }
		}

		private string indexOfPlace;
		public string IndexOfPlace
        {
			get { return indexOfPlace; }
			set { indexOfPlace = value; }
		}
	}
}
