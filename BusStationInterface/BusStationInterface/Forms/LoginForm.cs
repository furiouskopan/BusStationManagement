using BusStationInterface.Data;
using BusStationInterface.Models;
using BusStationInterface.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStationInterface.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void InsertEmployees()
        {
            using (var context = new BusManagementContext())
            {
                var employees = new List<Employee>
                {
                    new Employee
                    {
                        Name = "John Doe",
                        ContactInformation = "john.doe@example.com",
                        StationID = 1, 
                        Username = "john_doe",
                        PasswordHash = BCrypt.Net.BCrypt.HashPassword("johnsPassword123"),
                        Role = "Administrator" 
                    },
                    new Employee
                    {
                        Name = "Jane Smith",
                        ContactInformation = "jane.smith@example.com",
                        StationID = 1, 
                        Username = "jane_smith",
                        PasswordHash = BCrypt.Net.BCrypt.HashPassword("janesPassword456"),
                        Role = "User" 
                    }
                };

                context.Employees.AddRange(employees);
                context.SaveChanges();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            txtUsername.BackColor = SystemColors.Control;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Check if both the username and password fields are empty
            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }
            else if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }

            using (var context = new BusManagementContext())
            {
                // Retrieve the employee by the entered username
                var employee = context.Employees
                                      .FirstOrDefault(emp => emp.Username == username);

                if (employee != null)
                {
                    // Verify the password
                    if (VerifyPassword(password, employee.PasswordHash))
                    {
                        // Login success
                        //MessageBox.Show("Login successful!");

                        UserSession.StartSession(employee.EmployeeID, employee.Role, employee.Name);

                        // Optionally, open the main form and close the login form
                        //var mainForm = new Form1(employee);  // Pass employee info as needed
                        var mainForm = new Form1();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Password does not match
                        MessageBox.Show("Invalid password.");
                    }
                }
                else
                {
                    // User not found
                    MessageBox.Show("User not found.");
                }
            }
        }

        private bool VerifyPassword(string enteredPassword, string storedHash)
        {
            // Example using BCrypt
            return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHash);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertEmployees();
        }
    }
}
