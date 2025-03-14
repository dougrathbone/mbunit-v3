// Copyright 2005-2010 Gallio Project - http://www.gallio.org/
// Portions Copyright 2000-2004 Jonathan de Halleux
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Gallio.Icarus
{
    public partial class Window : DockContent
    {
        public string Id
        {
            get;
            private set;
        }

        public Control Content
        {
            get;
            private set;
        }

        internal Window(string id, Control content, string caption)
        {
            InitializeComponent();

            Id = id;

            Content = content;
            Controls.Add(content);
            content.Dock = DockStyle.Fill;

            TabText = caption;
        }

        protected override string GetPersistString()
        {
            return Id;
        }

        private void closeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
