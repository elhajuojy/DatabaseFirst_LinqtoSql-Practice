using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseFirst_LinqtoSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void afficher()
        {
            var reqfill = from emp in _db.Employees
                          select emp;
            var reqDeptName = from dep in _db.Departments
                              select new {  deptName = dep.DeptName, DeptId=dep.DeptID};


            cbDept.DataSource = reqDeptName.ToList();
            cbDept.DisplayMember = "deptName";
            cbDept.ValueMember = "DeptId";
            


            dgv.DataSource = reqfill.ToList();




            foreach (var emp in reqfill)
            {
                ListBox.Items.Add(emp.EmpName + " ---- " + emp.Job);
            }
        }

        CompanyDBEntities _db = new CompanyDBEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            afficher();

        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.EmpID = int.Parse(txtID.Text);

            var emp2 = from emp in _db.Employees
                       where emp.EmpID == emp1.EmpID
                       select emp;

            dgv.DataSource = emp2.ToList();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.EmpID = int.Parse(txtID.Text);

            emp1 = (from emp in _db.Employees
                       where emp.EmpID == emp1.EmpID
                       select emp).FirstOrDefault();

            //dgv.DataSource = emp2.ToList();

            _db.Employees.Remove(emp1);
            _db.SaveChanges();

            var reqshow = _db.Employees.Select(c => c);
            dgv.DataSource = reqshow.ToList();
            MessageBox.Show("succes");


        }

        private void btnModifer_Click(object sender, EventArgs e)
        {

            Employee emp1 = new Employee();
            emp1.EmpID = int.Parse(txtID.Text);

            emp1 = (from emp in _db.Employees
                    where emp.EmpID == emp1.EmpID
                    select emp).FirstOrDefault();
            emp1.EmpName = txtName.Text;
            emp1.Salary = 400000;
            _db.SaveChanges();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
                Employee emp3 = new Employee();
                emp3.EmpID = int.Parse(txtID.Text);
                emp3.EmpName = txtName.Text;
                _db.Employees.Add(emp3);
                _db.SaveChanges();
                MessageBox.Show("bien Ajtouer");
        }

        private void btnOrderSalire_Click(object sender, EventArgs e)
        {
            var orderbySalary = from emp in _db.Employees
                                orderby emp.Salary ascending
                                select emp;
            dgv.DataSource = orderbySalary.ToList();
                             
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var reqGroupby = from emp in _db.Employees
                             group emp by emp.DeptNO into groupto
                             select new { depno = groupto.Key , nbr = groupto.Count()};

            dgv.DataSource = reqGroupby.ToList();
                            
                             
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var selectAll = from emp in _db.Employees
                            select new { id = emp.EmpID, Name = emp.EmpName, salary = emp.Salary };
            dgv.DataSource = selectAll.ToList();
        }

        private void btnFremer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtJob.Text = string.Empty;
            txtName.Text = string.Empty;
            txtSalary.Text = string.Empty;
            cbDept.Items.Clear();
            dtpEmbauche.Value = DateTime.Now;

            
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txtID.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            txtJob.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
            dtpEmbauche.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
            txtSalary.Text = dgv.SelectedRows[0].Cells[4].Value.ToString();
            cbDept.Text = dgv.SelectedRows[0].Cells[5].Value.ToString();
            
        }

        private void BtnJoinEmpWithDept_Click(object sender, EventArgs e)
        {
            var joinEmpWithdept = from emp in _db.Employees
                                  join dept in _db.Departments
                                  on emp.DeptNO equals dept.DeptID
                                  select new
                                  {
                                      EmpName = emp.EmpName,
                                      EmpJob = emp.Job,
                                      EmpSalary = emp.Salary,
                                      DeptNO = dept.DeptID,
                                      DeptName = dept.DeptName
                                  };

            dgv.DataSource = joinEmpWithdept.ToList();

            ListBox.Items.Clear();
            foreach(var empDept in joinEmpWithdept)
            {
                ListBox.Items.Add(empDept.EmpName + "----> work in " + empDept.DeptName);
            }
        }

        private void cbDept_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //txtID.Text = cbDept.SelectedValue.ToString();
        }
    }
}
