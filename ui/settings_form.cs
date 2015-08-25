﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogWizard.ui {
    public partial class settings_form : Form {
        public settings_form() {
            InitializeComponent();
            load();
        }

        private void load() {
            viewLineCount.Checked = app.inst.show_view_line_count;
            viewLine.Checked = app.inst.show_view_selected_line;
            viewIndex.Checked = app.inst.show_view_selected_index;
        }

        private void save() {
            app.inst.show_view_line_count = viewLineCount.Checked;
            app.inst.show_view_selected_line = viewLine.Checked;
            app.inst.show_view_selected_index = viewIndex.Checked;
            app.inst.save();
        }

        private void settings_form_FormClosed(object sender, FormClosedEventArgs e) {
            save();
        }

        private void close_Click(object sender, EventArgs e) {
            save();
            DialogResult = DialogResult.OK;
        }
    }
}
