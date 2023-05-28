    public class HospitalContext:DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {

        }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Department> Departments { get; set; }
    }



-----------------
 "IdentityUser": "Server=.;Database=aspnet-Hospital-User;Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=true;Encrypt=False",
    "HospitalDB": "Server=.;Database=Hospital;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true;Integrated Security=true"
------------------
//
builder.Services.AddDbContext<HospitalContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("HospitalDB")));
// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("IdentityUser") ?? throw new InvalidOperationException("Connection string 'IdentityUser' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));