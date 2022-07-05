namespace State
{
    interface ApplicationAlamState
    {
        void releaseNewUpdate(ApplicationController contorller);
        void update(ApplicationController contorller);
    }
}
