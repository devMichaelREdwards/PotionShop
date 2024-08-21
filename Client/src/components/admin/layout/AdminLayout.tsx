import { Outlet } from 'react-router-dom';
import { Container, Content } from 'rsuite';
import AdminSideBar from '../navbar/AdminSideBar';

const AdminLayout = () => {
    return (
        <Container className='admin-panel'>
            <AdminSideBar />
            <Content>
                <Outlet />
            </Content>
        </Container>
    );
};

export default AdminLayout;
