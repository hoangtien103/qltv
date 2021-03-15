using System;
using System;
using System.Data;
using System.Windows.Forms;

public class MessageConfirm
{
	public MessageConfirm()
	{

	}

	string message = "Bạn có chắc muốn xóa Loại sách này?";
	string title = "Xác nhận xóa";
	MessageBoxButtons buttons = MessageBoxButtons.YesNo;
	DialogResult result = MessageBox.Show(message, caption: title, buttons);
}
