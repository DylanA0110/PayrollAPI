﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIPayroll.Api_Client;

namespace UIPayroll
{
    public partial class FrmPrincipal : Form
    {
        private readonly ApiClient _apiClient;
        public FrmPrincipal(ApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
        }
    }
}