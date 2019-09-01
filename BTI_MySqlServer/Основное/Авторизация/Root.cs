namespace BTI_MySqlServer
{
    class Root 
    {
        private readonly bool read, insert, edit, delete, setting;

        internal bool Delete
        {
            get
            {
                return delete;
            }
        }

        internal bool Edit
        {
            get
            {
                return edit;
            }
        }

        internal bool Insert
        {
            get
            {
                return insert;
            }
        }

        internal bool Read
        {
            get
            {
                return read;
            }
        }

        internal bool Setting
        {
            get
            {
                return setting;
            }
        }

        internal Root(bool read, bool insert, bool edit, bool delete, bool setting)
        {
            this.read = read;
            this.insert = insert;
            this.edit = edit;
            this.delete = delete;
            this.setting = setting;
        }
    }
}
