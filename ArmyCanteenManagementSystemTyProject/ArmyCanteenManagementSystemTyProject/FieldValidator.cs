using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace ArmyCanteenManagementSystemTyProject
{
    public static class FieldValidator
    {
        // Check if the field is empty
        public static bool IsEmpty(string input, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show($"{fieldName} cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        // Check if the field contains only digits
        public static bool IsNumeric(string input, string fieldName)
        {
            if (!Regex.IsMatch(input, @"^\d+$"))
            {
                MessageBox.Show($"{fieldName} must be Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        // Check if the field contains only letters
        public static bool IsAlpha(string input, string fieldName)
        {
            if (!Regex.IsMatch(input, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show($"{fieldName} must contain only letters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        // Check if the field contains valid email format
        public static bool IsEmail(string input, string fieldName)
        {
            if (!Regex.IsMatch(input, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show($"{fieldName} is not a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        // Check if the field contains a valid phone number
        public static bool IsPhoneNumber(string input, string fieldName)
        {
            if (!Regex.IsMatch(input, @"^\+?\d{7,15}$"))
            {
                MessageBox.Show($"{fieldName} is not a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        // Check if the field has a specific length
        public static bool HasMinLength(string input, string fieldName, int minLength)
        {
            if (input.Length < minLength)
            {
                MessageBox.Show($"{fieldName} must be at least {minLength} characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        // Check if the field value is within a specific range
        public static bool IsInRange(int input, string fieldName, int min, int max)
        {
            if (input < min || input > max)
            {
                MessageBox.Show($"{fieldName} must be between {min} and {max}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
    }
}
