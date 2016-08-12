/*
The MIT License (MIT)

Copyright (c) 2016 Wolfgang Almeida <wolfgang.almeida@yahoo.com>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;
using System.Windows.Forms;

namespace AlbanianVirus {
	public class MainClass {
		public static void Virus() {
			string virusTitle = "Virus Alert !";
			string virusMessage = "Hi, I am an Albanian virus but because of poor technology in my\n" +
			"country unfortunately I am not able to harm your computer. Please be\n" + 
			"so kind to delete one of your important files yourself and then forward\n" +
			"me to other users. Many thanks for your cooperation! Best\n" +
			"regards,Albanian virus";

			MessageBox.Show(virusMessage, virusTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
		}

		public static void Main() {
			Virus();
		}
	}
}